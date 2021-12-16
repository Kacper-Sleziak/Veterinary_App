using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Server.Database;

namespace Server
{
    internal class Program
    {
        public static Transactions _repository = new Transactions();
        public static PersonalDataCrud _personalData = new PersonalDataCrud();
        public static CredentialsCrud _credentials = new CredentialsCrud();
        public static AnimalsCrud _animals = new AnimalsCrud();
        public static PersonalDataCrud _products = new PersonalDataCrud();
        public static FreeTermsCrud _FreeTerms = new FreeTermsCrud();
        public static VisitsCrud _Visits = new VisitsCrud();

        // State object for reading client data asynchronously  
        public class StateObject
        {
            // Size of receive buffer.  
            public const int BufferSize = 1024;

            // Receive buffer.  
            public byte[] Buffer = new byte[BufferSize];

            // Received data string.
            public StringBuilder Sb = new StringBuilder();

            // Client socket.
            public Socket WorkSocket = null;
        }

        public class AsynchronousSocketListener
        {
            // Thread signal.  
            public static ManualResetEvent AllDone = new ManualResetEvent(false);

            public AsynchronousSocketListener()
            {
            }

            public static void StartListening()
            {
                // Establish the local endpoint for the socket.  
                // The DNS name of the computer  
                // running the listener is "host.contoso.com".  
                var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                var ipAddress = ipHostInfo.AddressList[0];
                var localEndPoint = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP socket.  
                var listener = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Bind the socket to the local endpoint and listen for incoming connections.  
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(100);

                    while (true)
                    {
                        // Set the event to nonsignaled state.  
                        AllDone.Reset();

                        // Start an asynchronous socket to listen for connections.  
                        Console.WriteLine("Waiting for a connection...");
                        listener.BeginAccept(
                            new AsyncCallback(AcceptCallback),
                            listener);

                        // Wait until a connection is made before continuing.  
                        AllDone.WaitOne();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                Console.WriteLine("\nPress ENTER to continue...");
                Console.Read();

            }

            public static void AcceptCallback(IAsyncResult ar)
            {
                // Signal the main thread to continue.  
                AllDone.Set();

                // Get the socket that handles the client request.  
                var listener = (Socket)ar.AsyncState;
                var handler = listener.EndAccept(ar);

                // Create the state object.  
                var state = new StateObject {WorkSocket = handler};
                handler.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
            }

            public static void ReadCallback(IAsyncResult ar)
            {
                // Retrieve the state object and the handler socket  
                // from the asynchronous state object.  
                var state = (StateObject)ar.AsyncState;
                var handler = state.WorkSocket;

                // Read data from the client socket.
                var bytesRead = handler.EndReceive(ar);

                if (bytesRead <= 0) return;
                // There  might be more data, so store the data received so far.  
                state.Sb.Append(Encoding.ASCII.GetString(
                    state.Buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read
                // more data.  
                var content = state.Sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    var result = "<EOF>";
                    // All the data has been read from the
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);

                    ////////////////////////////////////////
                    //tutaj switch , jaki content (dane od klienta) odpowiada jakiej funkcji i co wysłać
                    char[] separator = { '(', ',', ')' };
                    var function = content.Split(separator);

                    try
                    {
                        switch (function[0])
                        {
                            case "Login":
                                result = _repository.Login(function[1], function[2]).ToString();
                                break;
                            //Register for client
                            case "Register" when function.Length == 9:
                                result = _repository.Register(function[1], function[2], function[3], function[4],
                                    DateTime.Parse(function[5]), function[6], int.Parse(function[7])).ToString();
                                break;
                            case "Register":
                            {
                                if (function.Length == 10)
                                {
                                    result = _repository.Register(function[1], function[2], function[3], function[4],
                                            DateTime.Parse(function[5]), function[6], int.Parse(function[7]),
                                            function[8])
                                        .ToString();
                                }

                                break;
                            }
                            case "GetPersonalData":
                                result = _personalData.GetPersonalData(int.Parse(function[1]));
                                break;
                            //Klient przekazuje listę w postaci [el1;el2;el3;el4...]
                            case "AddNewVisit":
                                result = _repository.addNewVisit(int.Parse(function[1]), int.Parse(function[2]),
                                    int.Parse(function[3]), int.Parse(function[4])).ToString();
                                break;
                            case "Order":
                            {
                                char[] listSeparator = {'[', ';', ']'};
                                var ProductId =
                                    function[9].Split(listSeparator).ToList().ConvertAll(input => int.Parse(input));
                                var ProductAmount =
                                    function[10].Split(listSeparator).ToList().ConvertAll(input => int.Parse(input));
                                result = _repository.Order(int.Parse(function[1]), DateTime.Parse(function[2]),
                                    function[3], int.Parse(function[4]), function[5],
                                    function[6], function[7], function[8], ProductId, ProductAmount).ToString();
                                break;
                            }
                            case "CancelVisit":
                                result = _repository.CancelVisit(int.Parse(function[1])).ToString();
                                break;
                            case "ChangePassword":
                                result = _credentials.UpdateCredentials(int.Parse(function[1]), function[2],
                                    function[3],
                                    int.Parse(function[4])).ToString();
                                break;
                            case "GetAnimals":
                                result = _animals.GetAnimalsOfOwner(int.Parse(function[1]));
                                break;
                            case "GetVisitsOfAnimal":
                                result = _Visits.GetAnimalVisits(int.Parse(function[1])).ToString();
                                break;
                            case "GetVetVisits":
                                result = _Visits.GetVetVisits(int.Parse(function[1])).ToString();
                                break;
                            case "GetFreeTerms":
                                result = _FreeTerms.GetFreeTerms(int.Parse(function[1]));
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                        Console.WriteLine("  Message: {0}", ex.Message);
                        result = $"Commit Exception Type: {ex.GetType()} Message: {ex.Message}";
                    }

                    result += "<EOF>";

                    ////////////////////////////////////////

                    // Echo the data back to the client.
                    Send(handler, result);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReadCallback), state);
                }
            }

            private static void Send(Socket handler, String data)
            {
                // Convert the string data to byte data using ASCII encoding.  
                var byteData = Encoding.ASCII.GetBytes(data);

                // Begin sending the data to the remote device.  
                handler.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), handler);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.  
                    var handler = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.  
                    var bytesSent = handler.EndSend(ar);
                    Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            public static int Main(string[] args)
            {
                StartListening();
                return 0;
            }
        }
    }
}
