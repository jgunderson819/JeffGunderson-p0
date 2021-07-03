using System;
using System.Collections.Generic;
using Models;

namespace DL
{
    /// <summary>
    /// It is responsible for accessing our database (in this case it will be a JSON file stored in our folder)
    /// </summary>
    public interface IRepositoryStore
    {
        /// <summary>
        /// Gets a list of Restaurants stored in our database
        /// </summary>
        /// <returns>Returns a list of Store</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// It will get a specific Store
        /// </summary>
        /// <param name="p_stor">This Store object will be used to check the properties that should match in the database</param>
        /// <returns>Will return the store object from the database</returns>
        Store GetStore(Store p_stor);

        /// <summary>
        /// It will ad a Store in our database
        /// </summary>
        /// <param name="p_stor">This is the restaurant object that will be added to the database</param>
        /// <returns>Will return the restaurant object we just added</returns>
        Store AddStore(Store p_stor);
    }
}