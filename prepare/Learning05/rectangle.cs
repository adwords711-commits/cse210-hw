using System.Dynamic;
using System.Runtime.CompilerServices;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;
    public Rectangle(String color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width =  width;
    }
    public override double GetArea()
    {
        return _lenght * _width;
    }
}