using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // change encoding so we could print euros
            
            Console.OutputEncoding = Encoding.UTF8;

            // Escaping characters inside a string


            //string myString = "My \"so-called\" \nlife\\";
            //string myString = @"My so-called life\";

            // You can reuse parameters of the string format in any order

            //string myString = String.Format("{0} = {1} + {1}","First","Second");

            // Currency formatting

            //string myString = $"Currency: {123.45:C}";

            //number formatting

            //string myString = $"Nmber: {1234567890:N}";

            // percentage format

            // string myString = $"Percentage: {.123:P}";

            // Custom format

            //string myString = $"Custom format: {1234567890:(###) ###-####}";


            // string myString = " That summer we took threes across the board  ";

            // Start the string from 6th position and get 14 characters from there

            //myString = myString.Substring(6,14);

            // transform text to uppercase

            //myString = myString.ToUpper();

            // Replace character

            //myString = myString.Replace(" ", "--");

            //Remove a character form string

            //myString = myString.Remove(6, 14);

            // Trim the string

            //myString = $"Length before: {myString.Length}, length after: {myString.Trim().Length}";

            //myString = "";

            /*for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            } */

            // Optimal string manipulation

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
