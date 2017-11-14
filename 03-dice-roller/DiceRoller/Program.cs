using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am a dice rolling game.\nTo get Your dice rolling result write \"/roll\" followed by dice values into the program");

            Console.WriteLine("Example: > /roll 3d6 2d8");
            Console.WriteLine();

            // Take user input from Command Line

            string userInput = Console.ReadLine();

            //Initialize the user input parser class

            DiceRollCommandParser diceRollList = new DiceRollCommandParser();

            // get a list of Dice class objects from the user input

            var inputDiceRolls = diceRollList.getDiceRollList(userInput);

            // initialize the class, that assembles the singular dicerolls

            DiceRoller diceRoller = new DiceRoller();

            // Create and populate a list of diceroll values and descritions for printing

            List<DiceRoll> diceRolls = diceRoller.Roll(inputDiceRolls);

            // Write the dice description and 

            foreach (var diceRoll in diceRolls)
            {
                 Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: {diceRolls.Sum(x => x.Value)}");
            Console.WriteLine();
            Console.Write("> ");
             
            Console.ReadLine(); 
        }
    }
}
