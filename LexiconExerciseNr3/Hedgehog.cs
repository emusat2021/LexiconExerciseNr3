using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Hedgehog: Animal
    {
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public override string? Color { get; set; }

        public int NumberOfSpikes { get; set; }

        public Hedgehog(int age, int weight, string? color, int numberOfSpikes) : base(age, weight, color) 
        {
            NumberOfSpikes = numberOfSpikes;
        }
        public override string DoSound()
        {
            return "Hedydyd";
        }
    }
}
