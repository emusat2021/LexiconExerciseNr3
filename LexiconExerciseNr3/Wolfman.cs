using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(int age, int weight, string color, int packRank) : base(age, weight, color, packRank)
        {
        }

        public string Talk()
        {
            return "Let's make persons learn animal's language!";
        }
    }
}
