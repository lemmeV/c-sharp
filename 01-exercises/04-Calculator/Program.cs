using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen sulle nende summa");
            Console.WriteLine(Environment.NewLine);

            int firstNumber;
            int secondNumber;

            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Esimene number: " + firstNumber);
            Console.WriteLine("Teine number: " + secondNumber);

            double sum;
            sum = firstNumber + secondNumber;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Tulemuseks on: " + sum);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
