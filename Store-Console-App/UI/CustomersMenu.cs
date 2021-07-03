using System;
using System.Threading;

namespace UI
{
    public class CustomersMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Customers Menu!");
            Console.WriteLine("What would you like to do");
            Console.WriteLine("[2] Add a Customer");
            Console.WriteLine("[1] Give list of Customers");
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
                    return MenuType.ShowCustomersMenu;
                case "2":
                    return MenuType.AddCustomersMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.RestCustomersMenu;
            }
        }
    }
}