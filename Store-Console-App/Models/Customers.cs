using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customers
    {
        private string _city;
        public Customers()
        {
            Name = "Default";
        }

        public Customers(string p_name)
        {
            Name = p_name;
        }
        public string Name { get; set; }
        public string City
        {

            get
            {
                return _city;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //This will throw an exception whenever you try to store the city property with numbers
                    throw new Exception("City can only hold letters!");
                }

                _city = value;
            }

        }
        public string State { get; set; }

        public List<Customers> ReviewsCust { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, State: {State}, Email: {Email}. Orders: {OrdersList}";
        }
    }
}