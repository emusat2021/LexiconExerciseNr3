﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    public class Wolf : Animal
    {
        public override int Age { get; set ; }
        public override int Weight { get ; set ; }
        public override string? Color { get ; set ; }

        public int PackRank { get; set ; }

        public Wolf(int age, int weight, string color, int packRank) : base(age, weight, color) 
        {
            PackRank = packRank ;
        }
        public override string DoSound()
        {
            return "Woof";
        }
        public override string Status()
        {
            return $"Age: {Age}\nWeight: {Weight}\n Color:{Color}\n PackRank: {PackRank}";
        }
    }
}

