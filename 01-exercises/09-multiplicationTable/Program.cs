using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print out a multiplication table

            Console.WriteLine("\n-------------------------------------------");

            // Loop through the rows

            for (int i = 1; i <= 9; i++)
            {
               
                // Loop through the items in row

                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{ j * i} | ");
                }
                Console.WriteLine("\n-------------------------------------------");
                
            }
            Console.ReadLine();
        }
    }
}
