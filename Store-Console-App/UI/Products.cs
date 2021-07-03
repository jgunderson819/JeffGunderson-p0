using System;
using System.Threading;

namespace UI
{
    public class ProductsMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Products Menu!");
            Console.WriteLine("What would you like to do");
            Console.WriteLine("[2] Add a Product");
            Console.WriteLine("[1] Give list of Products");
            Console.WriteLine("[0] Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.ShowProductsMenu;
                case "2":
                    return MenuType.AddProductsMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ProductsMenu;
            }
        }
    }
}