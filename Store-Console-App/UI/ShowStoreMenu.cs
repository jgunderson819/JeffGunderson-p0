using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    public class ShowStoreMenu : IMenu
    {
        private IStoreBL _stBL;
        public ShowStoreMenu(IStoreBL p_st)
        {
            _stBL = p_st;
        }
        public void Menu()
        {
            Console.WriteLine("List of Stores");

            List<Store> Store = _stBL.GetAllStores();

            foreach (Store st in Stores)
            {
                Console.WriteLine("=============================");
                Console.WriteLine(st);
                Console.WriteLine("=============================");
            }

            Console.WriteLine("[0] Go Back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStoreMenu;
            }
        }
    }
}