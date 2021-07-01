using System;

namespace UI
{

    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Go to the Restaurant Menu");
            Console.WriteLine("[0] Exit");

        }

        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1";
                    return (RestaurantMenucd)
            }
        }
    }
}