using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Address chapelAddress = new Address("711 Crums Church Rd", "Berryville", "VA", 22611, "USA");
        Address receptionAddress = new Address("44365 Fair Oaks Rd", "Winchester", "VA", 22610, "USA");
        Address parkAddress = new Address("123 Park lakes Av", "Winchester", "VA", 224022, "USA");

        Lecture lecture = new Lecture("Stake Fireside", "An evening message focused on faith and service", "December 28, 2025", "7:00 PM", chapelAddress, "President Johnson", 250);
        Reception wardDinner = new Reception("ward Dinner", "Join us for dinner and followship with the ward.", "December 31, 2025", "7:00 PM", receptionAddress, "jorg_e1@me.com");
        OutdoorGathering wardPicnic = new OutdoorGathering("Picnic", "Outdoor food and sports activities", "April 26, 2026", "10:00 AM", parkAddress, "Clear skies");

        Console.WriteLine("LECTURE");
        Console.WriteLine(lecture.GetDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("RECEPTION");
        Console.WriteLine(wardDinner.GetDetails());
        Console.WriteLine();
        Console.WriteLine(wardDinner.FullDetails());
        Console.WriteLine();
        Console.WriteLine(wardDinner.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("OUTDOOR GATHERING");
        Console.WriteLine(wardPicnic.GetDetails());
        Console.WriteLine();
        Console.WriteLine(wardPicnic.FullDetails());
        Console.WriteLine();
        Console.WriteLine(wardPicnic.ShortDescription());
        Console.WriteLine();

    }
}