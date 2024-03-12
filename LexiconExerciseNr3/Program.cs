using System.ComponentModel.Design;
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
            Animal wolfman = new Wolfman(30, 75, "multi", 2);

            List<Animal> animals = new List<Animal>
            {
                dog,
                wolf,
                wolfman
            };
            /*
            foreach (Animal animal in animals) 
            {
                if (animal is IPerson)
                {
                    Console.WriteLine(animal.GetType().Name);
                    IPerson newI = (IPerson) animal;
                    Console.WriteLine(newI.Talk());
                }
                else 
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine($"{animal.Stats()} Sound: {animal.DoSound()};");

                }
            }
            */

            /*
            //List of dogs:
            Horse horse = new Horse(7, 100, "brown", 40);
            List<Dog> dogs = new List<Dog>
            {
                //horse,
            };
            */


            //3.4.11 - 12  Animal Stats
            /*
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            */


            //3.4.14
            /*
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }
            */

            //3.4.16
            foreach (Animal animal in animals)
            {
                //Console.WriteLine(animal.Breed());
            }
            



        }
    }

}

/*
 *** Answers to F Questions: ***
 -  3.3.13 F - If I will need to implement a new field or property to all classes that inherit Bird class-
    -then I will implement it in base Bird class.
    It could be possible to implement the new propertie even in Animal base class for Bird class-
     -but I asume that it will be a specific propertie just for birds, so no other animal will need to have it.
 - 3.3.14 F - If all animals will need to add a new field or property to their classes that inherit Animal class-
    -then I will implement a new field or property in base Animal class;
-------------------
- 3.4.9 - It is not working adding horse type Horse to a list type Dog. 
           This because there are two separate types even if both are derived from class Animal.
- 3.4.10 - The list must be Animal type for the both Dog and Horse to be able to be addede on the list.
- 3.4.13 - Wolfman derived from class Wolf. 
            Wolfman do not neeed, for example, the packrank property but Wolfman-
            -inherits the Wolf together with all Wolf's properties.
- 3.4.16 - Animal can not access Breed method of the Dog class because that is Dog that inherit Animal.
- 3.4.17 - Dog has access to all Animal method but the Animal has no access to Dog separata methods.



 */
