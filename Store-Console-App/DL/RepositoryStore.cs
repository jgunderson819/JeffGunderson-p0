using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace DL
{
    public class RepositoryStore : IRepositorySrore
    {
        private const string _filePath = "./../RRDL/Database/Store.json";
        private string _jsonString;
        public Store AddStore(Store p_stor)
        {
            List<Store> listOfStores = this.GetAllStore();
            listOfStores.Add(p_stor);

            _jsonString = JsonSerializer.Serialize(listOfStores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, _jsonString);
            return p_stor;
        }

        public List<Store> GetAllStore()
        {
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            }
            catch (System.Exception)
            {
                throw new Exception("File path is invalid");
            }

            //This will return a list of restaurant from the jsonString that came from 
            return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);
        }

        public Store GetStore(Store p_stor)
        {
            throw new System.NotImplementedException();
        }
    }
}