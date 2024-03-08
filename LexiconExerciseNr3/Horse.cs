using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Horse: Animal
    {
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public override string? Color { get; set; }

        public int Speed { get; set; }

        public Horse(int age, int weight, string? color, int speed) : base(age, weight, color) 
        {
            Speed = speed;
        }
        public override string DoSound()
        {
            return "Ihaha";
        }
    }
}
