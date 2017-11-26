using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_graded_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("-------------------------------------------");

            string itemSum = null;
            double subtotal = 0.00;
            Console.WriteLine(subtotal);

            while (itemSum != "-1")
            {
                Console.Write("Enter price of food item [-1 to quit]:");
                itemSum = Console.ReadLine();

                if (itemSum == "-1")
                {
                    break;
                }

                subtotal += double.Parse(itemSum);
                Console.WriteLine(subtotal);

            }

            double gratuity = subtotal * 0.15;
            double totalSum = subtotal - gratuity;

            Console.WriteLine($"Subtotal: {subtotal.ToString("0.##")}");
            Console.WriteLine($"15.00 % Gratuity: €{gratuity.ToString("0.##")}");
            Console.WriteLine($"Total: €{totalSum.ToString("0.##")}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
