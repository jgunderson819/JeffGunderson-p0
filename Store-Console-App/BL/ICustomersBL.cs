using System;
using System.Collections.Generic;
using Models;

namespace BL
{
    /// <summary>
    /// Handles all the business logic for the Customers model
    /// They are in charge of further processing/ sanitizing/ further validation of data
    /// Any logic that is used to access the data is for the DL, anything else will be in BL
    /// </summary>
    public interface ICustomersBL
    {
        /// <summary>
        /// Gets all the Customers from the database
        /// </summary>
        /// <returns>Returns a list of Customers</returns>
        List<Customers> GetAllCustomers();

        Customers AddCustomers(Customers p_cust);
    }
}
