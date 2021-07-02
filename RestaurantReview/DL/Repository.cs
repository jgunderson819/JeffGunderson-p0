using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace DL
{
    public class Repository : IRepository
    {
        private const string _filePath = "./../DL/Database/Restaurant.json";

        private string _jsonString;

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            List<Restaurant> listOfRestaurants = this.GetAllRestaurant();
            listOfRestaurants.Add(p_rest);

            _jsonString = JsonSerializer.Serialize(listOfRestaurants, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_filepath, _jsonString);
            return p_rest;

        }

        public List<Restaurant> GetAllRestaurant()
        {
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            }
            catch (System.Exception)
            {
                throw new Exception("File path  is invalid");
            }

            /// This will return a list of restaurants from the jsonString 

            return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);


        }

        public Restaurant GetRestaurant(Restaurant p_rest)
        {
            throw new System.NotImplementedException();
        }
    }


}
    }
}

