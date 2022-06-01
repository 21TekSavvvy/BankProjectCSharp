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
    public class CustomersDataAccessLayer : ICustomersDataAccessLayer
    {
        #region Fields
        private List<Customer> customers;
        #endregion

        #region Constructors
        public CustomersDataAccessLayer()
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

        /// <summary>
        /// Returns List of customers that are matching with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with expression</param>
        /// <returns>List of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            //create a new customer list
            List<Customer> customersList = new List<Customer>();
            // filter the collection
            List<Customer> filteredCustomer = Customers.FindAll(predicate);
            // copy all customer from the source collection into the new Customers list
            filteredCustomer.ForEach(item => customersList.Add(item.Clone() as Customer));
            return customersList;
        }
        /// <summary>
        /// Adds a new customer to the existing list
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Returns Guid of a newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            // generate new guid
            customer.CustomerID = Guid.NewGuid();
            //add customer
            Customers.Add(customer);
            return customer.CustomerID;
        }
        /// <summary>
        /// Updates an existing customer's detail
        /// </summary>
        /// <param name="c">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateCustomer(Customer c)
        {
            try
            {
                // find existing customer by CustomerID
                Customer existingCustomer = Customers.Find(item => item.CustomerID == c.CustomerID);

                // update all details of customer
                if (existingCustomer != null)
                {
                    existingCustomer.CustomerCode = c.CustomerCode;
                    existingCustomer.CustomerName = c.CustomerName;
                    existingCustomer.Address = c.Address;
                    existingCustomer.City = c.City;
                    existingCustomer.Mobile = c.Mobile;
                    existingCustomer.Landmark = c.Landmark;
                    existingCustomer.Country = c.Country;

                    return true;

                }
                else
                {
                    return false;
                }

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
        /// Deletes an existing customer based on customerID
        /// </summary>
        /// <param name="cID">CustomerID to delete</param>
        /// <returns>Indicates whether the Customer is delted or not</returns>
        public bool DeleteCustomer(Guid cID)
        {
            try
            {
                //delete customer by customerID
                if (Customers.RemoveAll(item => item.CustomerID == cID) > 0)
                {
                    return true; // indicates one or more customers are deleted
                }
                else
                {
                    return false; // indicates no customer is deleted
                }
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
