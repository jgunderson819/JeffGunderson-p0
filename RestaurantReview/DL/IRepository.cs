using System;
using System.Collections.Generic;
using Models;

namespace DL
{

    ///<summary>
    /// It is responsible for accessing our database (in this case it will be a JSON file stored in our folder)
    ///<summary>
    public interface IRepository
    {
        ///<summary>
        /// Get a list of Restaurants stored in our database
        ///<summary>

        List<Restaurant> GetAllRestaurant();

        /// <summary>
        /// It will get a specific restarant
        ///<summary>
        /// <param name="p_rest"> This is the restaurant object that will be added to the database <param>
        ///<returns> will return the retauant object from the database</returns>

        Restaurant AddRestaurant(Restaurant p_rest);




    }
}