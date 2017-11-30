using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing the array are separate

            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            // Declare and initialize in one line

            string[] words = new string[] { "one","two","three"};

            // It is possible to iterate through an array with either FOR or FOREACH loop

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // reverse a string

            string quote = "You can get what you want in life if you help enough other people to get what they want";
            Console.WriteLine(quote);
            
            // Split the string into invididual characters and then print out the entire string in reverse using FOR loop

            char[] charArray = quote.ToCharArray();
            Array.Reverse(charArray);

            foreach (var quoteChar in charArray)
            {
                Console.Write(quoteChar);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Maximum value in the numbers array is: {numbers.Max()}");
            Console.WriteLine($"Words array length is: {words.Length}");
            Console.ReadLine();

        }
    }
}
