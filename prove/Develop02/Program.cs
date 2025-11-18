using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    
    {
        Journal MyJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
    
        Console.WriteLine("Welcome to the Journal Program! ");
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select on of the following choices ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Exit ");
            Console.Write("What dould you like to do? ");
            int choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
            {
                string randomPrompt = promptGen.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                DateTime theCurrentTIme = DateTime.Now;
                string dateText = theCurrentTIme.ToShortDateString();

                Entry entry = new Entry(randomPrompt, response, dateText);
                MyJournal.AddEntry(entry);

            }
        else if (choice == 2)
            {
                MyJournal.Display();
            }
        else if (choice == 3)
            {
                Console.WriteLine("Enter a file name ");
                string fileName = Console.ReadLine();
                MyJournal.SaveToFile(fileName);
            }
        else if (choice == 4)
            {
                Console.WriteLine("Enter a file name ");
                string fileName = Console.ReadLine();
                MyJournal.LoadFromFile(fileName);
            }
        else if (choice == 5)
            {
                running = false;
            }
        
        }
    }
}