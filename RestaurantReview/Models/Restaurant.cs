using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{

    public class Restaurant
    {

        private string _city;



        public Restaurant()
        {
            Name = "Default";
        }

        public Restaurant(string p_name)
        {
            Name = p_name;
        }

        public Restaurant(string name, string state)
        {
            this.Name = name;
            this.State = state;

        }
        public string Name { get; set; };

        public string City
        {

            get
            {
                return _city;
            }

            set
            {
                if (!Regex.IsMatch(value, "@^[A-Za-z .]+$"))
                {
                    throw new Exception("City can only hold letters!");
                }

                _city = value;
            }
        }
        public string State { get; set; }

        public List<Review> Reviews { get; set; }


    }
}