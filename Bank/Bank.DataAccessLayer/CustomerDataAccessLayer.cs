using System;
using System.Collections.Generic;
using Bank.Entities;
using Bank.Exceptions;
using Bank.DataAccessLayer.DAL_Contracts;

namespace Bank.DataAccessLayer
{
    /// <summary>
    /// Represents DAL for bank customer
    /// </summary>
    public class CustomerDataAccessLayer : ICustomersDataAcessLayer
    {
        #region Fields
        private List<Customer> customers;
        #endregion

        #region Constructors
        public CustomerDataAccessLayer()
            {
                customers = new List<Customer>();
            }
        #endregion


        #region Properties
        /// <summary>
        /// Represents source customers collection
        /// </summary>
        private List<Customer> Customers
        {
            set => customers = value;
            get => customers;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>Customers list</returns>
        public List<Customer> GetCustomers()
        {
            //create a new customer list
            List<Customer> customersList = new List<Customer>();
            // copy all customer from the source collection into the new Customers list
             Customers.ForEach(item =>customersList.Add(item.Clone() as Customer));
            return customersList;
        }
        public List<Customer> GetCustomersByCondition()
        {

        }
        #endregion
    }
}
