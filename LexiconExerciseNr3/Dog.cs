using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Dog : Animal
    {
        public override int Age { get; set; }
        public override int Weight { get; set; }
        public override string? Color { get; set; }

        public int NumberOfTheeth {  get; set; }

        public Dog(int age, int weight, string? color, int numberOfTheeth) : base(age, weight, color) 
        {
            NumberOfTheeth = numberOfTheeth;
        }
        public override string DoSound()
        {
            return "HamHam";
        }
    }
}
