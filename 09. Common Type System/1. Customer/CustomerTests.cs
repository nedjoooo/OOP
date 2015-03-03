using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class CustomerTests
    {
        static void Main(string[] args)
        {
            Customer baiIvan = new Customer("Ivan", "Vylkov", "Goshev", "8503285842", "Planet Earth", "+359987654321",
                "baiIvan@kambanka.com",
                new List<Payment>() 
                { 
                    new Payment("some product", 45.99m),
                    new Payment("other some product", 55.49m)
                }, 
                CustomerType.OneTime);

            Console.WriteLine(baiIvan);

            Customer baiYordan = baiIvan.Clone() as Customer;

            if(baiIvan == baiYordan)
            {
                Console.WriteLine("baiIvan equals baiGoran");
            }
            else
            {
                Console.WriteLine("baiIvan and baiGoran not equals");
            }

            Console.WriteLine();

            Console.WriteLine("Changes baiGoran");
            baiYordan.FirstName = "Yordan";
            Console.WriteLine(baiYordan);

            Console.WriteLine();

            Console.Write("Compare baiIvan and baiGoran: ");
            if(baiIvan.CompareTo(baiYordan) == 1)
            {
                Console.WriteLine("baiYordan");
            }
            else if (baiIvan.CompareTo(baiYordan) == -1)
            {
                Console.WriteLine("baiIvan");
            }

            Console.WriteLine();

            if (baiIvan == baiYordan)
            {
                Console.WriteLine("baiIvan equals baiGoran");
            }
            else
            {
                Console.WriteLine("baiIvan and baiGoran not equals");
            }
        }
    }
}
