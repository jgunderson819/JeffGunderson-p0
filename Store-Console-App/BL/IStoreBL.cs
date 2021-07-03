using System;
using System.Collections.Generic;
using Models;

namespace BL
{
    /// <summary>
    /// Handles all the business logic for the store model
    /// They are in charge of further processing/ sanitizing/ further validation of data
    /// Any logic that is used to access the data is for the DL, anything else will be in BL
    /// </summary>
    public interface IStoreBL
    {
        /// <summary>
        /// Gets all the stores from the database
        /// </summary>
        /// <returns>Returns a list of stores</returns>
        List<Store> GetAllStore();

        Store AddStore(Store p_stor);
    }
}
