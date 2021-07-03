using System;
using System.Collections.Generic;
using Models;

namespace DL
{
    /// <summary>
    /// It is responsible for accessing our database (in this case it will be a JSON file stored in our folder)
    /// </summary>
    public interface IRepositoryCust
    {
        /// <summary>
        /// Gets a list of Customers stored in our database
        /// </summary>
        /// <returns>Returns a list of Customers</returns>
        List<Customers> GetAllCustomers();

        /// <summary>
        /// It will get a specific customer
        /// </summary>
        /// <param name="p_cust">This restaurant object will be used to check the properties that should match in the database</param>
        /// <returns>Will return the restaurant object from the database</returns>
        Restaurant GetCustomers(Customers p_cust);

        /// <summary>
        /// It will ad a customer in our database
        /// </summary>
        /// <param name="p_cust">This is the Customers object that will be added to the database</param>
        /// <returns>Will return the Customers object we just added</returns>
        Customers AddCustomers(Customers p_cust);
        Customers GetCustomers(Customers p_cust);
    }
}