using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a boolean property to manage exiting out of the program

            bool displayMenu = true;

            // while we are in the program, display the menu to the user

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            // Clear the console windows from previous text

            Console.Clear();

            // Write the menu options in the console for the user

            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Print Numbers Game");
            Console.WriteLine("2) Guess the number");
            Console.WriteLine("3) Exit");

            // Catch the user input

            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {

            // Clear the console windows from previous text

            Console.Clear();

            Console.WriteLine("Print Numbers Game");
            Console.WriteLine("Type a number: ");
            int result = int.Parse(Console.ReadLine());

            int counter = 1;

            while(counter < result+1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            // Clear the console windows from previous text

            Console.Clear();

            Console.WriteLine("Guessing game!");

            // Initialize the Random class to get a random number for the game

            Random myRandom = new Random();

            // The second number signifies the first number that is out of bounda 1,11 === 1-10

            int randomNumber = myRandom.Next(1, 11);

            //

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();

                if (result == randomNumber.ToString())

                    incorrect = false;

                else
                    // if the guess is incorrect, then print it and increase the guesses counter 

                    Console.WriteLine("Wrong!");
                    guesses++;


            } while (incorrect);

            Console.WriteLine("Correct! You guessed {0} times",guesses);

            Console.ReadLine();
        }
    }
}
