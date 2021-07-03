using BL;
using DL;

namespace UI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.ShowStoreMenu:
                    //ShowStoreMenu needs a StoreBL object in the parameter because it depends on that object to be able to run its functionality
                    //StoreBL needs the Repository object in the parameter because it depends on that object to be able to run
                    //This is call Dependency Injection
                    return new ShowStoreMenu(new StoreBL(new Repository()));
                case MenuType.AddStoreMenu:
                    return new AddStoreMenu(new StoreBL(new Repository()));
                case MenuType.CustomersMenu:
                    return new CustomersMenu();
                case MenuType.ShowCustomersMenu:
                    //ShowCustomersMenu needs a RestaurantBL object in the parameter because it depends on that object to be able to run its functionality
                    //CustomersBL needs the Repository object in the parameter because it depends on that object to be able to run
                    //This is call Dependency Injection
                    return new ShowCustomersMenu(new CustomersBL(new Repository()));
                case MenuType.AddCustomersMenu:
                    return new AddCustomersMenu(new CustomersBL(new Repository()));
                case MenuType.ProductsMenu:
                    return new ProductsMenu();
                case MenuType.ShowProductsMenu:
                    //ShowProductsMenu needs a RestaurantBL object in the parameter because it depends on that object to be able to run its functionality
                    //ProductsBL needs the Repository object in the parameter because it depends on that object to be able to run
                    //This is call Dependency Injection
                    return new ShowProductsMenu(new ProductsBL(new Repository()));
                case MenuType.AddProductsMenu:
                    return new AddProductsMenu(new ProductsBL(new Repository()));
                default:
                    return null;
            }
        }
    }
}