using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    public abstract class Animal
    {
        public abstract int Age { get; set; }
        public abstract int Weight { get; set; }
        public abstract string? Color { get; set; }

        protected Animal(int age, int weight, string? color)
        {
            Age = age;
            Weight = weight;
            Color = color;
        }
        public abstract string DoSound();

        public abstract string Status();
  


    }
}
