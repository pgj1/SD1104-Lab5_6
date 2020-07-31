using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab5_6_if_Then
{
    class Program
    {
        struct Customer
        {
            public string id;
            public string fname;
            public string lname;
            public int age;
            public bool member;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lab 5.6 If/Then  \n");
            
            // Create customers 
            //1. Customer 1 is under age
            Customer cust1 = new Customer
            {
                id = "cust01",
                fname = "Bob",
                lname = "Smith",
                age = 19,
                member = false
            };

            //2. Customer 2 is legal age but not a premium member
            Customer cust2 = new Customer
            {
                id = "cust02",
                fname = "Bobbie",
                lname = "Smith",
                age = 25,
                member = false
            };

            //3.Customer 3 is legal age and a premium member
            Customer cust3 = new Customer
            {
                id = "cust03",
                fname = "Robert",
                lname = "Smith",
                age = 35,
                member = true
            };

            //Put customers in format to loop through
            Customer[] allCustomers = {cust1, cust2, cust3};

            //check status of each customer

            for (int i = 0; i < allCustomers.Length; i++)
                if (allCustomers[i].age < 21)
                    Console.WriteLine("\n" + allCustomers[i].id + " " + allCustomers[i].fname + " " + allCustomers[i].lname + " is underage and cannot place an order.");
                else if (allCustomers[i].member == false)
                    Console.WriteLine("\n" + allCustomers[i].id + " " + allCustomers[i].fname + " " + allCustomers[i].lname + " can place a beer order and pays regular price.");
                else
                {
                    Console.WriteLine("\n" + allCustomers[i].id + " " + allCustomers[i].fname + " " + allCustomers[i].lname + " can place a beer order and is a premium member.");
                };

            Console.WriteLine("\n \n **** End of Lab 5.6 **** ");
          
        }
    }
}
