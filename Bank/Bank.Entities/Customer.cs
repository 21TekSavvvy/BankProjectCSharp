using System;
using Bank.Entities.Contracts;

namespace Bank.Entities
{
    /// <summary>
    /// Represents customer of the bank
    /// </summary>
     public class Customer : ICustomer
    {

        //fields
        private Guid customerID;
        private string customerCode;
        private string customerName;
        private string address;
        private string city;
        private string country;
        private string mobile;


        //properties
        public Guid CustomerID { get => customerID; set => customerID = value; }
        public string CustomerCode { get => customerCode; set => customerCode = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Mobile { get => mobile; set => mobile = value; }
    }
}
