using System;

namespace JediMindTricks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Exercise 1

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Exercise 2

            Dictionary<string, int> people = new Dictionary<string, int>();

            people.Add("Frederik", 25);
            people["Steve"] = 20;

            Console.WriteLine(people["Frederik"]);

            // Exercise 3

            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            // Remove Han from dictionary (if it exists)
            if (!characters.Remove("Han"))
            {
                Console.WriteLine("The element, \"Han\", could not be found.");
            }

            // Exercise 4

            foreach (var character in characters)
            {
                Console.WriteLine(character.Value);
            }
        }
    }
}