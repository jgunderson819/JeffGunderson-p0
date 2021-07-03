using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ShowProductsMenu : IMenu
    {
        private IProductsBL _stBL;
        public ShowProductMenu(IProductsBL p_st)
        {
            _prodBL = p_prod;
        }
        public void Menu()
        {
            Console.WriteLine("List of Products");

            List<Customers> Products = _prodBL.GetAllStores();

            foreach (Customers prod in Products)
            {
                Console.WriteLine("=============================");
                Console.WriteLine(prod);
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
                    return MenuType.ProductsMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowProductsMenu;
            }
        }
    }
}