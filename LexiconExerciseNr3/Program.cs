using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LexiconExerciseNr3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Person person = new Person();
            try
            {
                Console.WriteLine("Add age.");
                person.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Add a first name.");
                person.FName = Console.ReadLine().ToLower();
                Console.WriteLine("Add a last name.");
                person.LName = Console.ReadLine().ToLower();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            */

            /*
            PersonHandler personHandler = new PersonHandler();
            Person mary = personHandler.CreatePerson(25, "mary", "luca", 1.70, 70);
            Person harry = personHandler.CreatePerson(25, "harry", "monroe", 1.70, 70);

            Console.WriteLine(mary.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(harry.ToString());
            */

            /*
            UserError numericInputError = new NumericInputError();
            UserError textInputError = new TextInputError();
            //från tre egna classer
            UserError syntaxInputError = new SyntaxInputError();
            UserError insufficentLengthError = new InsufficentLengthError();
            UserError negativInputNumberError = new NegativInputNumberError();

            List<UserError> errors = new List<UserError>
            { 
                numericInputError,
                textInputError,

                syntaxInputError,
                insufficentLengthError,
                negativInputNumberError
            };
            foreach (UserError error in errors) 
            {
                Console.WriteLine(error.UEMessage());
            }
            */
            Animal dog = new Dog(3, 6, "brown", 20);
            Animal wolf = new Wolf(5, 10, "white", 1);

            List<Animal> animals = new List<Animal>
            {
                dog,
                wolf
            };
            
            foreach (Animal animal in animals) 
            {
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
            }



        }
    }
}
/*
 *** Answers to F Questions: ***
 -  3.3.13 F - If I will need to implement a new field or property to all classes that inherit Bird class 
    then I will implement it in base Bird class.
    It could be possible to implement the new propertie even in Animal base class for Bird class
     but I asume that it will be a specific propertie just for birds, so no other animal will need to have it.
 - 3.3.14 F - If all animals will need to add a new field or property to their classes that inherit Animal class 
    then I will implement a new field or property in base Animal class;
-------------------

 */
