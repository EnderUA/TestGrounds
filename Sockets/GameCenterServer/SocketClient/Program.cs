using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SynchronousClient.StartClient();

            Console.WriteLine("Client ended...");
            Console.Read();
        }
    }
}
