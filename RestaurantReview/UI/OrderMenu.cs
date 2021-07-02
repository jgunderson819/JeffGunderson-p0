using System;

namespace UI
{

    public class RestaurantMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the RestaurantMenu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] List of Restaurants");
            Console.WriteLine("[0] Go Back");
        }


        public string YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "MainMenu";
                    break;
                case "1":
                    return "RestaurantMenu";
                    break;
                default:
                    return "Unknown";

            }
        }
    }
}