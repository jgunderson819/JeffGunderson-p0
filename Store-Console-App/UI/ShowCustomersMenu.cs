using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ShowCustomersMenu : IMenu
    {
        private const string Value = "List of Customers";
        private ICustomersBL _stBL;
        public ShowCustomersMenu(ICustomersBL p_st)
        {
            _custBL = p_cust;
        }
        public void Menu()
        {
            Console.WriteLine(value: Value);

            List<Customers> Customers = _custBL.GetAllStores();

            foreach (Customers cust in Customers)
            {
                Console.WriteLine("=============================");
                Console.WriteLine(cust);
                Console.WriteLine("=============================");
            }

            Console.WriteLine("[0] Go Back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return MenuType.CustomersMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomersMenu;
            }
        }
    }
}