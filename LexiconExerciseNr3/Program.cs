namespace LexiconExerciseNr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
