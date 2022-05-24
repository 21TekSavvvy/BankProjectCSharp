using System;
using Bank.Entities.Contracts;
using Bank.Exceptions;

namespace Bank.Entities
{
    /// <summary>
    /// Represents customer of the bank
    /// </summary>
     public class Customer : ICustomer
    {

        #region Private fields
        private Guid customerID;
        private long customerCode;
        private string customerName;
        private string address;
        private string city;
        private string country;
        private string mobile;
        #endregion

        #region Public Properties
        /// <summary>
        /// Guid of Customer for Unique identification
        /// </summary>
        public Guid CustomerID { get => customerID; set => customerID = value; }

        /// <summary>
        /// Auto-generated code number of the customer
        /// </summary>
        public long CustomerCode 
        {
            get => customerCode;
            set
            {
                if (value > 0)
                {
                    customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer code should be positive only");
                }    
            }
        }
        /// <summary>
        /// Name of Customer
        /// </summary>
        public string CustomerName { get => customerName; set => customerName = value; }
        /// <summary>
        /// Address of Customer
        /// </summary>
        public string Address { get => address; set => address = value; }
        /// <summary>
        /// City of Customer
        /// </summary>
        public string City { get => city; set => city = value; }
        /// <summary>
        /// Country of Customer
        /// </summary>
        public string Country { get => country; set => country = value; }
        /// <summary>
        /// Phone Number of Customer
        /// </summary>
        public string Mobile { get => mobile; set => mobile = value; }
        #endregion
    }
}
