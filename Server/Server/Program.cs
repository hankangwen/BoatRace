using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boat Race Server Start.");
            EchoServer server = new EchoServer("127.0.0.1", 8888);
            server.Start();
        }
    }
}
