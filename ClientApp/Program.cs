using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientService.ContextServiceClient contextServiceClient = new ClientService.ContextServiceClient();

            Console.WriteLine(contextServiceClient.GetData(1));
            Console.ReadLine();
        }
    }
}
