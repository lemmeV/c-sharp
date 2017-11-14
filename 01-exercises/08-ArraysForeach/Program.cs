using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ArraysForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "one", "two", "three" };

            int count = 0;
            foreach (string excuse in excuses)
            {
                count += 1;
                Console.WriteLine(count + ". " + excuse);

            }
            Console.ReadLine();
        }
    }
}
