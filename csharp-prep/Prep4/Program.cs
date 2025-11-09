using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finish. ");
        List<int> numbers = new List<int>();
        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter number ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);

            }
        }
        /* calculate the sum or total of the numbers in the list*/
        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum += number;
        }
        Console.WriteLine($"The sum is: {totalSum} ");

        /*Compute the average of the numbers in the list*/
        double average = (double)totalSum / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        /*Compute the largest number*/
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber} ");


    }
}