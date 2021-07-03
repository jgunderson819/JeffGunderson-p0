using System;
using System.Collections.Generic;
using Models;

namespace DL
{
    /// <summary>
    /// It is responsible for accessing our database (in this case it will be a JSON file stored in our folder)
    /// </summary>
    public interface IRepositoryProd
    {
        /// <summary>
        /// Gets a list of Products stored in our database
        /// </summary>
        /// <returns>Returns a list of Products</returns>
        List<Products> GetAllProducts();

        /// <summary>
        /// It will get a specific restaurant
        /// </summary>
        /// <param name="p_prod">This restaurant object will be used to check the properties that should match in the database</param>
        /// <returns>Will return the restaurant object from the database</returns>
        Products GetProducts(Products p_prod);

        /// <summary>
        /// It will ad a product in our database
        /// </summary>
        /// <param name="p_prod">This is the Products object that will be added to the database</param>
        /// <returns>Will return the Products object we just added</returns>
        Restaurant AddProducts(Products p_prod);
    }
}