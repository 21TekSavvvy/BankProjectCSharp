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
        private List<Customer> Customers
        {
            set => customers = value;
            get => customers;
        }
        #endregion

        #region Methods
        public List<Customer> GetCustomers()
        {
            return Customers;
        }
        #endregion
    }
}
