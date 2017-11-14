using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Possible outcomes/cases:
            // 1. Input is not a integer
            // 2. The inserted number is not between 1 and 100
            // 3. The integer entered is smaller than our number
            // 4. The integer entered is larger than our number
            // 5. The correct answer was entered

            Console.WriteLine("Ma valin välja ühe suvalise numbri (1-100). Proovi see ära arvata");
            Console.WriteLine(Environment.NewLine);

            // Declare a number to guess 

            int randomNumber = 71;

            // Take user input

            string userInput = Console.ReadLine();

            //Declare an integer to hold the number the user inserted

            int userInputValue;

            // Check if the input is a number
       
            if(int.TryParse(userInput, out userInputValue))
            {
                // Check the number against our set value
           
                if (randomNumber > userInputValue)
                {
                    Console.WriteLine("Sinu pakutud number on väiksem");

                }
                else if (randomNumber < userInputValue && userInputValue <= 100)
                {

                    Console.WriteLine("Sinu pakutud number on suurem");
                }
                else if (randomNumber == userInputValue)
                {
                    Console.WriteLine("Õnnitlused! Arvasid numbri ära!");
                }
                else
                {
                    Console.WriteLine("Sisestatud number ei ole 1-100 sees");
                }
            } else
            {
                Console.WriteLine("Sa ei sisestanud numbrit! Palun käivita programm uuesti ja proovi veelkord");
            }

            Console.ReadLine();
        }
    }
}
