using System;
using System.Collections.Generic;
using Models;

namespace BL
{
    /// <summary>
    /// Handles all the business logic for the Products model
    /// They are in charge of further processing/ sanitizing/ further validation of data
    /// Any logic that is used to access the data is for the DL, anything else will be in BL
    /// </summary>
    public interface IProductsBL
    {
        /// <summary>
        /// Gets all the Products from the database
        /// </summary>
        /// <returns>Returns a list of products</returns>
        List<Products> GetAllProducts();

        Products AddProducts(Products p_prod);
    }
}
