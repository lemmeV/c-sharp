using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_graded_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Taco Palenque", "1200 Main ST.");

            string itemSum = null;
            Tab tab = new Tab();

            while (itemSum != "-1")
            {
                Console.Write("Enter price of food item [-1 to quit]:");
                itemSum = Console.ReadLine();

                if (itemSum == "-1")
                {
                    break;
                }

                tab.Add(itemSum);

            }

            Receipt receipt = new Receipt(tab.subtotal);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
