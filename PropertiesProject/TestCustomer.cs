using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProject
{
    internal class TestCustomer
    {
        static void Main()
        {
            Customer c = new Customer(101, true, "Mark", 1000,Cities.Bangalore,"Karnataka");    //here we cannot access the private members(fields) of the class Customer directly, so we use properties
            Console.WriteLine("Customer Id: " + c.CustId);
            Console.WriteLine("Customer Status: " + c.Status);
            
            c.CustName = "Johnson";
            Console.WriteLine("Customer Name: " + c.CustName);
            c.Balance-=100;
            c.Balance -= 500;
            Console.WriteLine("Customer Balance: " + c.Balance);
            Console.WriteLine(c.City);
            c.City = Cities.Kolkata;
            Console.WriteLine(c.City);
            Console.WriteLine(c.State);
            //c.State = "West Bengal";
            Console.WriteLine(c.State);
            Console.WriteLine(c.Country);
            //c.Country = "Nepal";
            Console.WriteLine(c.Country);
        }
    }
}
