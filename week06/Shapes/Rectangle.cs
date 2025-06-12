public class Rectangle : Shape
{
    // store color
    // store two side lengths

    private double _height;
    private double _width;

    public Rectangle(string name, string color, double height, double width) : base(name, color)
    {
        _height = height;
        _width = width;
    }

    public override double GetArea()
    {
        return _height * _width;
    }
}