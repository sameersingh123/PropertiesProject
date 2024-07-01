using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProject
{
     class ReviseTestBank
    {
        static void Main()
        {
            ReviseBank bank = new ReviseBank(101, true, "Sameer", 50000, Cities.Bangalore, "Karnataka");
            Console.WriteLine(bank.CustId);   //accessing is similar to a variable
            Console.WriteLine(bank.Status);
            Console.WriteLine(bank.CustName);
            bank.CustName += " Singh";
            Console.WriteLine(bank.CustName);
            Console.WriteLine(bank.Balance);
            bank.Balance += 1000;
            Console.WriteLine(bank.Balance);
            bank.Balance -= 50600;
            Console.WriteLine(bank.Balance);
            Console.WriteLine(bank.City);
            bank.City=Cities.Kolkata;
            Console.WriteLine(bank.City);
            Console.WriteLine(bank.State);
            bank.State = "West Bengal";
            Console.WriteLine(bank.State);
            Console.WriteLine(bank.Country);
        }
    }
}
