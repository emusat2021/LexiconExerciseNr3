using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Bird : Animal
    {
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public override string? Color { get; set; }
        public int WingDiameter { get; set; }


        public Bird(int age, int weight, string? color, int wingDiameter) : base(age, weight, color) 
        {
            WingDiameter = wingDiameter;
        }
        public override string DoSound()
        {
            return "Cracra";
        }
    }
}
