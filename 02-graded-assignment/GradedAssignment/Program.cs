using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am a discount calculator. Please provide a total sum and i will tell You how much you can save!");

            decimal first_discount_level = 5;
            decimal second_discount_level = 10;
            decimal third_discount_level = 20;

            int inputSum = int.Parse(Console.ReadLine());

            if (inputSum > 500)
            {
                decimal discount = third_discount_level / 100;
                Console.WriteLine($"You entered the sum of {inputSum}$");
                Console.WriteLine($"You will get a {third_discount_level}% discount");
                Console.WriteLine($"You will need to pay {inputSum - inputSum * discount}$");
            }
            else if (inputSum > 250)
            {
                decimal discount = second_discount_level / 100;
                Console.WriteLine($"You entered the sum of {inputSum}$");
                Console.WriteLine($"You will get a {second_discount_level}% discount");
                Console.WriteLine($"You will need to pay {inputSum - inputSum * discount}$");
            }
            else if (inputSum > 50)
            {
                decimal discount = first_discount_level / 100;
                Console.WriteLine($"You entered the sum of {inputSum}$");
                Console.WriteLine($"You will get a {first_discount_level}% discount");
                Console.WriteLine($"You will need to pay {inputSum - inputSum * discount}$");
            }
            else
            {
                Console.WriteLine("Discount will be applied on purchases over 50$");
                Console.WriteLine($"You will need to pay {inputSum}$");
            }

            Console.ReadLine();
        }
    }
}
