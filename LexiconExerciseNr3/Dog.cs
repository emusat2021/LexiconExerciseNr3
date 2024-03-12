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

        public int NumberOfTeeth {  get; set; }

        public Dog(int age, int weight, string? color, int numberOfTeeth) : base(age, weight, color) 
        {
            NumberOfTeeth = numberOfTeeth;
        }
        public override string DoSound()
        {
            return "HamHam";
        }
        public override string Stats()
        {
            return $"{GetType().Name} (Age: {Age}, Weight: {Weight}, Color:{Color}, NumberOfTeeth: {NumberOfTeeth});";
        }

        public string Breed()
        {
            return "SomeDogBreed";
        }
    }
}
