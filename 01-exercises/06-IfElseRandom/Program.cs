using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IfElseRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri (1-100). Proovi see ära arvata");
            Console.WriteLine(Environment.NewLine);

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            int userInput = userInputFunction();
            //Console.WriteLine("random on " + randomNumber);

            while (randomNumber != userInput)
            {
                if (randomNumber > userInput)
                {
                    Console.WriteLine("Sinu pakutud number on väiksem");
                    userInput = userInputFunction();
                }
                else if (randomNumber < userInput)
                {
                    Console.WriteLine("Sinu pakutud number on suurem");
                    userInput = userInputFunction();
                }
            }

            Console.WriteLine("Õnnitlused! Arvasid numbri ära!");
            Console.ReadLine();
        }
        static int userInputFunction()
        {
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Sina pakud: " + userInput);
            return userInput;
        }

    }

}
