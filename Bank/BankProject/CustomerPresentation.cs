using System;
using System.Collections.Generic;
using Bank.Entities;
using Bank.Exceptions;
using Bank.BusinessLogicLayer;
using Bank.BusinessLogicLayer.BALContracts;

namespace Bank.Presentation
{
    static class CustomerPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                // create an object of customer
                Customer c = new Customer();

                // read all details from the user
                Console.WriteLine("\n **********ADD CUSTOMER**********");
                Console.WriteLine("Customer Name: ");
                c.CustomerName = Console.ReadLine();
                Console.WriteLine("Address: ");
                c.Address = Console.ReadLine();
                Console.WriteLine("Landmark: ");
                c.Landmark = Console.ReadLine();
                Console.WriteLine("City: ");
                c.City = Console.ReadLine();
                Console.WriteLine("Mobile: ");
                c.Mobile = Console.ReadLine();


                // Create BL object
                ICustomersBusinessLogicLayer cBLL = new CustomerBusinessLogicLayer();
                Guid newGuid = cBLL.AddCustomer(c);
               List<Customer> matchingCustomers = cBLL.GetCustomersByCondition(item=> item.CustomerID == newGuid);
                if(matchingCustomers.Count>=1)
                {
                    Console.WriteLine("New Customer Code: " + matchingCustomers[0].CustomerCode); 
                    Console.WriteLine("Customer Added.\n");
                }
                else
                {
                    Console.WriteLine("Customer not added!");
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
           


        }

    }
}

