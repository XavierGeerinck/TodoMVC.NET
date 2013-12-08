using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // localhost:9000 = bind to loopback
            // *:9000 = bind to all addresses
            string url = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Server started on {0}", url);
                Console.ReadKey();
            }
        }
    }
}
