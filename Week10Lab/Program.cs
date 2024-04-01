using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10Lab.Models.Entities;


namespace Week11CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new MMABooksContext();

            var customers = dbContext.Customers;

            // Display the customers
            foreach (var customer in customers)

            {

                Console.WriteLine(customer.Name);

            }
        }
    }
}