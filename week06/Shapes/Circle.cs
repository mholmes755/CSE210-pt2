public class Circle : Shape
{
    // store color
    // store radius
    private double _radius;

    public Circle(string name, string color, double radius) : base(name, color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius; // Math.PI is a constant for the value of pi
    }
}