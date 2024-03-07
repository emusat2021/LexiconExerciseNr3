using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LexiconExerciseNr3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFirstName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public void SetLastName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public Person FullName(Person pers, string lName, string fName)
        {
            Person fullName = new Person();

            fullName.LName = lName;
            fullName.FName = fName;
            return fullName;

        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname,
                string lname, double height, double weight)
        {
            Person newPerson = new Person();
     
                newPerson.Age = age;
                newPerson.FName = fname;
                newPerson.LName = lname;
                newPerson.Height = height;
                newPerson.Weight = weight;
       
            return newPerson;
        }
        public override string ToString()
        {
            return "";
        }


    }
}
