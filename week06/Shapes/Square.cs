using System.Reflection.Metadata;

public class Square : Shape
{
    // store color
    // store side length
    private double _sideLength;

    public Square(string name,  string color, double sideLength) : base(name, color)
    {
        _sideLength = sideLength;
    }

    public override double GetArea()
    {
        return _sideLength * _sideLength;
    }
}