using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCustomerClient
{
    class Program
    {
        private static async Task<IList<Customer>> GetCustomersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync("http://localhost:50734/CustomerService.svc/customers/");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }

        private static async Task<IList<Customer>> GetCustomersAsyncById()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync("http://localhost:50734/CustomerService.svc");
                IList<Customer> cList2 = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList2;
            }
        }

        static void Main(string[] args)
        {
            

            foreach (var item in GetCustomersAsyncById().Result)
            {
                Console.WriteLine("Id: " + item.Id + " Fornavn: " + item.FirstName + " Efternavn: " + item.LastName + " År: " + item.Year);
            }


            foreach (var item in GetCustomersAsync().Result)
            {
                Console.WriteLine("Id: " + item.Id + " Fornavn: " + item.FirstName + " Efternavn: " + item.LastName + " År: " + item.Year);
            }
            

            Console.ReadLine();
        }
    }
}
