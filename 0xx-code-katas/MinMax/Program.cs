using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Your task is to make two functions, max and min (maximum and minimum in PHP) that take a(n) array/vector of integers list as input and outputs, 
             * respectively, the largest and lowest number in that array/vector.

            #Examples

            max({4,6,2,1,9,63,-134,566}) returns 566
            min({-52, 56, 30, 29, -54, 0, -110}) returns -110
            max({5}) returns 5
            min({42, 54, 65, 87, 0}) returns 0
            
             */

            int[] list = { 42, 54, 65, 87, 0 };
            int resultMax = Max(list);
            int resultMin = Min(list);
            Console.WriteLine($"Maksimum on: {resultMax}");
            Console.WriteLine($"Miinimum on: {resultMin}");
            Console.ReadLine();

        }
        public static int Min(int[] list)
        {
            int minimum = list[0];

            for (int i = 0; i < list.Length; i++)
            {
                minimum = (list[i] < minimum) ? list[i] : minimum;
            }

            return minimum;

        }

        public static int Max(int[] list)
        {
            int maximum = list[0];

            for (int i = 0; i < list.Length; i++)
            {
                maximum = (list[i] > maximum) ? list[i] : maximum;
            }

            return maximum;

        }
    }
}
