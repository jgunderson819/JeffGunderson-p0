using System;
using System.Threading;

namespace UI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Store Menu!");
            Console.WriteLine("What would you like to do");
            Console.WriteLine("[2] Add a Store");
            Console.WriteLine("[1] Give list of Stores");
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
                    return MenuType.ShowStoreMenu;
                case "2":
                    return MenuType.AddStoreMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}