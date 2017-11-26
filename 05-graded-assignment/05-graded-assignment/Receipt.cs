using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_graded_assignment
{
    class Receipt
    {
        public Receipt(double subtotal)
        {
            double gratuity = subtotal * 0.15;
            double totalSum = subtotal - gratuity;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Subtotal: {subtotal.ToString("0.##")}");
            Console.WriteLine($"15.00 % Gratuity: €{gratuity.ToString("0.##")}");
            Console.WriteLine($"Total: €{totalSum.ToString("0.##")}");
        }
    }
}
