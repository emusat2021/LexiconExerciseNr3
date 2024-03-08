using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Pelican : Bird
    {
       public int BeakLength { get; set; }
        public Pelican(int age, int weight, string? color, int wingDiameter, int beakLength) : base(age, weight, color, wingDiameter)
        {
            BeakLength = beakLength;
        }
    }
}
