using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Server.Database;

namespace Server
{
    class Program
    {
        public static Repository _repository = new Repository();
        static void Main()
        {
            Console.Write(_repository.RegisterUser("Adminator", "Adminarski", "Adam", "Adaasdmski", new DateTime(2000, 11, 15), "aaa@o2.pl", 123456789));
            Console.Read();
        }
    }
}
