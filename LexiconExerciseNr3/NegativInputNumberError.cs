using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    public class NegativInputNumberError : UserError
    {
        public override string UEMessage()
        {
            return "Negative input not allowed!";
        }
    }
}
