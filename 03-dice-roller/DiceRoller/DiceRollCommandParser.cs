using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRollCommandParser
    {
        private int rollCount;

        public DiceRollCommandParser()
        {
            
        }
        public List<Dice> getDiceRollList(string userInput)
        {

            // Define delimiters and break the user input into singular items

            char[] delimiterChars = { ' ' };
            string[] input = userInput.Split(delimiterChars);

            // Remove the first element /roll from the array

            string[] diceRollsInput = input.Where((item, index) => index != 0).ToArray();

            List<string> test = new List<string>();
            List<Dice> result = new List<Dice>();

            foreach (string roll in diceRollsInput)
            {
                // Get the number of dicerolls from the input and convert it to a number

                rollCount = int.Parse(roll.Split('d')[0]);

                // Loop through the rolls and add the result to a Dice object list using helper function

                for (int i = 0; rollCount > i; i++)
                {

                    //Get the method name we need to search for from Dice class

                    var method = roll.Substring(roll.LastIndexOf("d")).ToUpper(); ;
                    var diceObject = getDiceObject(method);
                  
                    result.Add(diceObject);
                }

            }

            //result.ForEach(Console.WriteLine);

            return result;
        }
        

        // Helper function that defines which method of the Dice obect/class will be used


        private Dice getDiceObject(string method)

        {
            if (method == "D4")
            {
                return Dice.D4;

            } else if (method == "D6")
            {
                return Dice.D6;

            } else if(method == "D8")
            {
                return Dice.D8;

            } else if (method == "D10")
            {
                return Dice.D10;

            } else if (method == "D12")
            {
                return Dice.D12;

            } else
            {
                return Dice.D20;
            }

        }

    }
}
