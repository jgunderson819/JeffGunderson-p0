using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace DL
{
    public class RepositoryCust : IRepositoryCust
    {
        private const string _filePath = "./../RRDL/Database/Customers.json";
        private string _jsonString;
        public Customers AddCustomers(Customers p_cust)
        {
            List<Customers> listOfCustomers = this.GetAllCustomers();
            listOfCustomers.Add(p_cust);

            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, _jsonString);
            return p_cust;
        }

        public List<Customers> GetAllRestaurantCustomers()
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
            return JsonSerializer.Deserialize<List<Customers>>(_jsonString);
        }

        public Customers GetCustomers(Customers p_cust)
        {
            throw new System.NotImplementedException();
        }
    }
}