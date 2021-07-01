namespace UI
{
    public interface IMenu
    {
        /// Displays menu of the classand choices

        void Menu();

        /// This method records the user's choice and changes the menu

        string YourChoice();

    }