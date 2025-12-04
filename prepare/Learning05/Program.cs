using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*Square sq = new Square("blue", 4);
        Rectangle rect = new Rectangle("Green", 3, 6);
        Circle circ = new Circle("Red", 5);

        Console.WriteLine(sq.GetColor() + " square area: " + sq.GetArea());
        Console.WriteLine(rect.GetColor() + " rectangle area: " + rect.GetArea());
        Console.WriteLine(circ.GetColor() + " circle area: " + circ.GetArea());
        */
        List<Shape> shapes = new List<Shape>();

        Square sqP = new Square("Purple", 3);
        shapes.Add(sqP);
        Square sqG = new Square("Green", 4);
        shapes.Add(sqG);
        Square sqY = new Square("Yellow", 6);
        shapes.Add(sqY);
        
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor() + " The area is: " + s.GetArea());
        }
    }

}