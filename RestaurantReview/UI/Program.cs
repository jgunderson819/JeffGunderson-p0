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
            }
        }
    }
}
