using System;
using System.ServiceModel;

namespace Project2HostWCF {
    internal class Program {
        private static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = newServiceHost(typeof(PostComment), newUri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se inhost.Description.Endpoints) Console.WriteLine(
                "A (address): {0} \nB (binding): {1} \nC (Contract): {2}\n", se.Address, se.Binding.Name,
                se.Contract.Name);
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            host.Close();
        }
    }
}