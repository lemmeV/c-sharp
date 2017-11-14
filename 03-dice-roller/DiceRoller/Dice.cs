using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        private int Sides { get; }

        public string Description { get; }

        private static Random Random { get; } = new Random();

        private Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
        }

        public static Dice D4 => new Dice(4, "d4");
        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");
        public static Dice D10 => new Dice(10, "d10");
        public static Dice D12 => new Dice(12, "d12");
        public static Dice D20 => new Dice(20, "d20");

        public int Roll()
        {
            return Dice.Random.Next(1, this.Sides + 1); // max value is exlusive, so we have to add +1
        }
    }
}
