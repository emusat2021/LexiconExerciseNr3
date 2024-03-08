using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Worm : Animal
    {
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public override string? Color { get; set; }

        public int SegmentCount { get; set; }
        public Worm(int age, int weight, string? color, int segmentCount) : base(age, weight, color)
        {
            SegmentCount = segmentCount;
        }
        public override string DoSound()
        {
            return "Shshsh";
        }
    }
}
