// My Exceeding requeriments it's that now I have a library of 3 scriptures with 3 references.
// And I will have it in a random order.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.")
        };

      
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[index];

      
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Memorization complete!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3); 
        }
    }
}
