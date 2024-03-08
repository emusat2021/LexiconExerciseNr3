using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Flamingo : Bird
    {
        public string PinkIntensity {  get; set; }
        public Flamingo(int age, int weight, string? color, int wingDiameter, string pinkIntensity) : base(age, weight, color, wingDiameter)
        {
            PinkIntensity = pinkIntensity;
        }
    }
}
