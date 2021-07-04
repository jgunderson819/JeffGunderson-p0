using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            restMenu.Menu();
            currentMenu = restMenu.YourChoice();

            switch (currentMenu)
            {
                case MenuType.MainMenu:
                    restMenu = menuFactory.GetMenu(MenuType.MainMenu);
                    break;
                case MenuType.StoreMenu:
                    restMenu = menuFactory.GetMenu(MenuType.RestaurantMenu);
                    break;
                case MenuType.ShowStoreMenu:
                    restMenu = menuFactory.GetMenu(MenuType.ShowRestaurantMenu);
                    break;
                case MenuType.AddStoreMenu:
                    restMenu = menuFactory.GetMenu(MenuType.AddRestaurantMenu);
                    break;
                case MenuType.Exit:
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Cannot process what you want please try again");
                    break;
            }
        }
    }
}

