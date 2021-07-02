using System;
using System.Collections.Generic;
using Models;

namespace BL
{

    ///<summary>
    ///  Handles all the logic for the businewss model
    /// They are in charge of further processing/ sanitizing/ further validation of data
    /// Any logic that is used to access the data is for the DL, anything else will be BL
    /// <summary>

    public interface IRestauantBL
    {
        /// <summary>
        /// Gets all the retaurant from the database
        ///  <summary>
        ///<returns> Returns list of restaurants<returns>

        List<Restaurant> GetAllRestaurant()

        Restaurant AddRestaurant(Restaurant p_rest);
    }

}