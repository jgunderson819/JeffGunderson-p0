using System;
using System.Collections.Generic;
using DL;
using Models;

namespace BL
{
    public class RestaurantBL : IRestaurantBL
    {
        ///<summary>
        /// We are defining the dependencies this class needs in the constructor
        /// We do it this way with interface because we can easily switch out the implementation of BL when we want to change data source
        /// change from file based to database stored in the cloud
        ///<summary>
        private IRepository _repo;

        public RestaurantBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            p_rest.State = p_rest.State.ToUpper();
            return _repo.AddRestaurant(p_rest);
        }

        public List<Restaurant> GetAllRestaurant()
        {
            return _repo.GetAllRestaurant();
        }

    }


}

}