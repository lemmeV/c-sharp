﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PrintText
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.Write("Tere! Palun sisesta oma nimi: ");
            string myName = Console.ReadLine();

            Console.WriteLine($"Minu nimi on {myName} ning õpin esimest korda programmeerima");
            Console.WriteLine();
            Console.WriteLine("Kindlasti on võimalik midagi rohkemat, kui lihtsalt teksti printimine \n");

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
