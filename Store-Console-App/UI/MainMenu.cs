using System;

namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[3] Go to Products Menu");
            Console.WriteLine("[2] Go to Cusomer Menu");
            Console.WriteLine("[1] Go to Store Menu ");
            Console.WriteLine("[0] Exit");
        }

        public string YourChoice()
        {
            //Console.ReadLine() method will record what you type in the terminal
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                    break;
                case "1":
                    return "RestaurantMenu";
                    break;
                case "2":
                    return "CustomerMenu";
                    break;
                case "3":
                    return "ProductMenu";
                    break;
                default:
                    return "Unknown";
            }
        }
    }
}