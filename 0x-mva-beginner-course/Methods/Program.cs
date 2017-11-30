using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           /**
            * Get the users name and city and write it out in reverse
            **/
            
            Console.WriteLine("The Name Game");

            string firstName = GetUserInput("What's your first name? ");
            string lastName = GetUserInput("What's your last name? ");
            string city = GetUserInput("In what city were you born? ");

            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                city = ReverseString(city));

            Console.ReadLine();
        }

        private static string ReverseString(string userInput)
        {
            char[] charArray = userInput.ToCharArray();

            Array.Reverse(charArray);

            return String.Concat(charArray);
        }

        private static string GetUserInput(string question)
        {
            Console.Write(question);

            string userInput = Console.ReadLine();

            return userInput;
        }

        private static void DisplayResult(
            string firstName, 
            string lastName, 
            string city)
        {
            Console.Write("Results: ");

            Console.Write("{0} {1} {2}",
                firstName,
                lastName,
                city);
        }
    }
}
