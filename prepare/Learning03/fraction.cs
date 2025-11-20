using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _bottom = 1;
    } 
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int Top
    {
        get{return _top; }
        set{_top = value; }
    }
    public int bottom
    {
        get{return _bottom; }
        set{_bottom = value; }
    }
}



