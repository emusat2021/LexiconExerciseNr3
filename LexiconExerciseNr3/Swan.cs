using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Swan : Bird
    {
        public double WingSpan {  get; set; } 
        public Swan(int age, int weight, string? color, int wingDiameter, double wingSpan) : base(age, weight, color, wingDiameter)
        {
            WingSpan = wingSpan;
        }
    }
}
