using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    
    {
        Journal MyJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
    
    
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Exit ");
            
            Console.Write("What dould you like to do? ");
            string choice = Console.ReadLine();
        }
    }
}