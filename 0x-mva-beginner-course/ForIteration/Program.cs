using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 0; i < 10; i++ )
            {
                Console.WriteLine(i);
                
            }

            // NB! ReadLine must be outside of loop - otherwise it will work only on the first loop

            Console.ReadLine();
        }
    }
}
