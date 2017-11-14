using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ArraysFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "one", "two", "three" };

            for (int i = 0; i < excuses.Length; i++)
            {
                Console.WriteLine($"{i + 1}, {excuses[i]}");
            }
            Console.ReadLine();
        }
    }
}
