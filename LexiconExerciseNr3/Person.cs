using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExerciseNr3
{
    internal class Person
    {

        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative input not allowed");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Length's first name must be between 2 and 10 characters");
                }
                else
                {
                    fName = value.ToUpper();
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Length's last name must be between 3 and 15 characters");
                }
                else
                {
                    lName = value.ToUpper();
                }
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public override string ToString()
        {
            return $"First Name: {FName}\nLast Name: {LName}\nAge: {Age}\nHeight: {Height}\nWeight: {Weight}";
        }

    }
}
