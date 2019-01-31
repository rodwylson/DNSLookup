using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DNSLookupAPP
{
    class Program
    {
        static void Main()
        {
            // Do a few lookups by host name and address  
            DNSLookup("msdn.microsoft.com");
            DNSLookup("207.46.16.248");

            // Keep the console window open in debug mode  
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        protected static void DNSLookup(string hostNameOrAddress)
        {
            Console.WriteLine("Lookup: {0}\n", hostNameOrAddress);

            IPHostEntry hostEntry = Dns.GetHostEntry(hostNameOrAddress);
            Console.WriteLine("  Host Name: {0}", hostEntry.HostName);

            IPAddress[] ips = hostEntry.AddressList;
            foreach (IPAddress ip in ips)
            {
                Console.WriteLine("  Address: {0}", ip);
            }

            Console.WriteLine();
        }
    }
}
