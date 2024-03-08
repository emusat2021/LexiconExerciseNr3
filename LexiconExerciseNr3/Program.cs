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


        }
    }
}
