using System;
using System.Collections.Generic;
using Bank.BusinessLogicLayer.BALContracts;
using Bank.DataAccessLayer;
using Bank.DataAccessLayer.DAL_Contracts;
using Bank.Entities;
using Bank.Exceptions;

namespace Bank.BusinessLogicLayer
{
    /// <summary>
    /// Represents customer business logic
    /// </summary>
    public class CustomerBusinessLogicLayer : ICustomersBusinessLogicLayer
    {
        #region Private Fields
        private ICustomersDataAccessLayer _customersDataAccessLayer;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor that initializes CustomersDataAccessLayer
        /// </summary>
        public CustomerBusinessLogicLayer()
        {
            _customersDataAccessLayer = new CustomersDataAccessLayer();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Private property that represents reference of CustomersDataAccessLayer
        /// </summary>
        private ICustomersDataAccessLayer CustomersDataAccessLayer
        {
            get => _customersDataAccessLayer;
            set => _customersDataAccessLayer = value;

        }

        #endregion
        #region Methods
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns></returns>

        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.GetCustomers();
            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }



        }
        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lamdba expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Adds a new customer to the existing list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates the customer is added successfully</returns>

        public Guid AddCustomer(Customer customer)
        {
            try
            {
                // get all customers
                List<Customer> allCustomers = CustomersDataAccessLayer.GetCustomers();
                long maxCustCode = 0;
                //determine the highest customer code
                foreach (var item in allCustomers)
                {
                    if (item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }
                }
                // generate a new customer no
                if (allCustomers.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                }
                else
                {
                    customer.CustomerCode = Configuration.Settings.BaseCustomerNo + 1;
                }

                //invoke DAL
                return CustomersDataAccessLayer.AddCustomer(customer);
            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {

                //invoke DAL
                return CustomersDataAccessLayer.UpdateCustomer(customer);
            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerId">Customer ID to delete</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.DeleteCustomer(customerID);
            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

    }
}