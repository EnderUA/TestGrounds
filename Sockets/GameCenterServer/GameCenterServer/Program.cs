using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace GameCenterServer
{
    class Program
    {
        static void Main(string[] args)
        {
            SynchronousServer.StartListening();

            Console.WriteLine("Server ended...");
            Console.ReadLine();
/*            WebClient wc = new WebClient();

            WebRequest webRequest = WebRequest.Create(@"https://www.google.com/");
            webRequest.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = webRequest.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);

            reader.Close();
            response.Close();

            Console.Read();*/
        }
    }
}
