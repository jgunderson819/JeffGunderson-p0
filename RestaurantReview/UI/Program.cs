using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu restMenu = new MainMenu();
            bool repeat = true;
            string currentMenu = "MainMenu";



            while (repeat)
            {


                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {
                    case "MainMenu":
                        1   restMenu = new MainMenu();
                        break;
                    case "Exit";
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Don't know what you want, try again");
                        break;

                }


            }
        }
    }
}
