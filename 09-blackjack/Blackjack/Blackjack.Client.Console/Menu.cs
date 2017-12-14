namespace Blackjack.Client.Console
{
    using System;

    class Menu
    {
        private bool displayMenu;

        public Menu()
        {
            displayMenu = true;
            MainMenu();
        }
        public void DisplayMainMenu()
        {
            // Catch the user input

            string result = Console.ReadLine();

            if (result == "1")
            {
                MainMenu();
            }
            else if (result == "2")
            {
                Environment.Exit(0);
            }
            else
            {
                MainMenu();
            }
        }
        private void MainMenu()
        {
            // Clear the console from previous text

            Console.Clear();

            // Write the menu options in the console for the user

            Console.WriteLine("What Would You like to do today? Choose an option by entering a number (1-2) ");
            Console.WriteLine("1) Play a fun game of Blackjack");
            Console.WriteLine("2) Exit the application");
        }

    }
}
