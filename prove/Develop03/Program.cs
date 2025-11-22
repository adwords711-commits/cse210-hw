using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 37, 6);
        Scripture scripture = new Scripture(reference, "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();
            if (input == "quit")
                break;
            scripture.HideRandomWords();

        }
    }
}