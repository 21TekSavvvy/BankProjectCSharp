﻿using System;
using System.Collections.Generic;
using Bank.Entities;


namespace Bank.BusinessLogicLayer.BALContracts
{
    /// <summary>
    /// Interface that represents customers business logic
    /// </summary>
    public interface ICustomersBusinessLogicLayer
    {
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns></returns>

        List<Entities.Customer> GetCustomers();
        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lamdba expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        List<Entities.Customer> GetCustomersByCondition(Predicate<Entities.Customer> predicate);

        /// <summary>
        /// Adds a new customer to the existing list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates the customer is added successfully</returns>

        Guid AddCustomer(Entities.Customer customer);

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        bool UpdateCustomer(Entities.Customer customer);

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerId">Customer ID to delete</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        bool DeleteCustomer(Guid customerId);
    }
}