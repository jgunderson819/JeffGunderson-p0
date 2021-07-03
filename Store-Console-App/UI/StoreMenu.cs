using System;

namespace UI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Store Menu!");
            Console.WriteLine("What would you like to do");
            Console.WriteLine("[2] Add a store");
            Console.WriteLine("[1] Give list of stores");
            Console.WriteLine("[0] Go Back");
        }

        public string YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    return "RestaurantMenu";
                default:
                    return "Unknown";
            }
        }
    }
}