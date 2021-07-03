using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Modelc;

namespace DL
{
    public class NewBaseType
    {
        public Products GetProducts(Products p_prod) => throw new System.NotImplementedException();
    }

    public class RepositoryProd : NewBaseType, IRepositoryProd
    {
        private const string _filePath = "./../RRDL/Database/Products.json";
        private string _jsonString;
        public Products AddProducts(Products p_prod)
        {
            List<Products> listOfProducts = this.GetAllProducts();
            listOfProducts.Add(p_rest);

            _jsonString = JsonSerializer.Serialize(listOfProducts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, _jsonString);
            return p_prod;
        }

        public List<Products> GetAllProducts()
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
            return JsonSerializer.Deserialize<List<Products>>(_jsonString);
        }
    }
}