using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Server.Database;

namespace Server
{
    class Program
    {
        public static Transactions _repository = new Transactions();
        public static PersonalDataCrud _personalData = new PersonalDataCrud();
        public static AnimalsCrud _animals = new AnimalsCrud();
        public static PersonalDataCrud _products = new PersonalDataCrud();

        // State object for reading client data asynchronously  
        public class StateObject
        {
            // Size of receive buffer.  
            public const int BufferSize = 1024;

            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];

            // Received data string.
            public StringBuilder sb = new StringBuilder();

            // Client socket.
            public Socket workSocket = null;
        }

        public class AsynchronousSocketListener
        {
            // Thread signal.  
            public static ManualResetEvent allDone = new ManualResetEvent(false);

            public AsynchronousSocketListener()
            {
            }

            public static void StartListening()
            {
                // Establish the local endpoint for the socket.  
                // The DNS name of the computer  
                // running the listener is "host.contoso.com".  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP socket.  
                Socket listener = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Bind the socket to the local endpoint and listen for incoming connections.  
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(100);

                    while (true)
                    {
                        // Set the event to nonsignaled state.  
                        allDone.Reset();

                        // Start an asynchronous socket to listen for connections.  
                        Console.WriteLine("Waiting for a connection...");
                        listener.BeginAccept(
                            new AsyncCallback(AcceptCallback),
                            listener);

                        // Wait until a connection is made before continuing.  
                        allDone.WaitOne();
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
                allDone.Set();

                // Get the socket that handles the client request.  
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = handler;
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
            }

            public static void ReadCallback(IAsyncResult ar)
            {
                String content = String.Empty;

                // Retrieve the state object and the handler socket  
                // from the asynchronous state object.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket handler = state.workSocket;

                // Read data from the client socket.
                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There  might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(
                        state.buffer, 0, bytesRead));

                    // Check for end-of-file tag. If it is not there, read
                    // more data.  
                    content = state.sb.ToString();
                    if (content.IndexOf("<EOF>") > -1)
                    {
                        String result = "<EOF>";
                        // All the data has been read from the
                        // client. Display it on the console.  
                        Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                            content.Length, content);

                        ////////////////////////////////////////
                        //tutaj ify , jaki content (dane od klienta) odpowiada jakiej funkcji i co wysłać
                        char[] spearator = { '(', ',', ')' };
                        var function = content.Split(spearator);

                        if (function[0] == "Login")
                        {
                            result = _repository.Login(function[1], function[2]).ToString();
                        }

                        else if (function[0] == "Register")
                        {
                            if (result.Length == 9)
                            {
                                result = _repository.Register(function[1], function[2], function[3], function[4],
                                 DateTime.Parse(function[5]), function[6], Int32.Parse(function[7])).ToString();
                            }

                            else if (result.Length == 10)
                            {
                                result = _repository.Register(function[1], function[2], function[3], function[4],
                                    DateTime.Parse(function[5]), function[6], Int32.Parse(function[7]), function[8]).ToString();
                            }

                            
                        }
                        
                        else if (function[0] == "GetPersonalData")
                        {
                            result = _personalData.GetPersonalData(Int32.Parse(function[1]));
                        }
                        
                        else if (function[0] == "AddNewVisit")
                        {
                            result = _repository.addNewVisit(Int32.Parse(function[1]), Int32.Parse(function[2]), Int32.Parse(function[3]), Int32.Parse(function[4])).ToString();
                        }

                        else if (function[0] == "CancelVisit")
                        {
                            result = _repository.CancelVisit(Int32.Parse(function[1])).ToString();             
                        }

                        

                        result += "<EOF>";

                        ////////////////////////////////////////

                        // Echo the data back to the client.
                        Send(handler, result);
                    }
                    else
                    {
                        // Not all data received. Get more.  
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReadCallback), state);
                    }
                }
            }

            private static void Send(Socket handler, String data)
            {
                // Convert the string data to byte data using ASCII encoding.  
                byte[] byteData = Encoding.ASCII.GetBytes(data);

                // Begin sending the data to the remote device.  
                handler.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), handler);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.  
                    Socket handler = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.  
                    int bytesSent = handler.EndSend(ar);
                    Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            public static int Main(String[] args)
            {
                StartListening();
                return 0;
            }
        }
    }
}
