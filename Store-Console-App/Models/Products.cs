using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Products
    {
        private string _descrption;
        public Restaurant()
        {
            Name = "Default";
        }

        public Restaurant(string p_name)
        {
            Name = p_name;
        }
        public Products(string name, string price)
        {
            this.Name = name;
            this.Price = price;

        }
        public Products(string name, string price)
        {
            this.Name = name;
            this.Price = price;

        }
        public Products(string name, string price)
        {
            this.Name = name;
            this.Price = price;

        }
        public string Name { get; set; }
        public string Description
        {

            get
            {
                return _description;
            }

            set
            {

                _description = value;
            }

        }
        public string Price { get; set; }

        public List<Products> Prod { get; set; }

        public override string ToString()
        {
            string v = $"Name: {Name}, Desc: {Description}, Price: {Price}";
            return v;
        }
    }
}