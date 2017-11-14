using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InputText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen papagoi programm. Ütle mulle midagi ja ma kordan selle sulle tagasi...");

            string userInput;
            userInput = Console.ReadLine();

            Console.WriteLine("Sina ütled: " + userInput);
            Console.WriteLine($"Mina ütlen: {userInput}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
