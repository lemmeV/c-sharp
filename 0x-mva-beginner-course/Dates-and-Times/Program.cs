using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString() );
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            Console.WriteLine(myValue.AddDays(2.5).ToLongDateString());
            Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1984, 10, 21);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("21.10.1984");
            Console.WriteLine(myBirthday.ToShortDateString());
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
