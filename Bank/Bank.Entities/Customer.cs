using System;
using Bank.Entities.Contracts;
using Bank.Exceptions;

namespace Bank.Entities
{
    /// <summary>
    /// Represents customer of the bank
    /// </summary>
     public class Customer : ICustomer, ICloneable
    {

        #region Private fields
        private Guid customerID;
        private long customerCode;
        private string customerName;
        private string address;
        private string landmark;
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
        public string CustomerName { get => customerName; set
            {
                if (value.Length <=40 && string.IsNullOrEmpty(value) == false)
                {
                    customerName = value; 
                }
                else
                {
                    throw new CustomerException("Customer Name should not be null and less than 40 characters long.");
                }
               
            }
               }
        /// <summary>
        /// Address of Customer
        /// </summary>
        public string Address { get => address; set => address = value; }
        /// <summary>
        /// Landmark of Customer
        /// </summary>
        public string Landmark { get => landmark; set => landmark = value; }
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
        public string Mobile { get => mobile; 
            set  
            {
                if (value.Length == 10)
                {
                    mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile number should be a 10 digit number");
                }
                
            }
        }
        #endregion

        #region Methods
        public object Clone()
        {
            return new Customer() { CustomerID = this.CustomerID, CustomerCode = this.CustomerCode, CustomerName = this.customerName, Address = this.Address, Landmark = this.Landmark, City = this.City, Country = this.Country, Mobile = this.Mobile };
        }
        #endregion

    }
}
