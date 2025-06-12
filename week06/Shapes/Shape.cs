public class Shape
{
    // color of the shape
    // GetArea method
    // Don't story area as a method, but store the sides and then compute the area

    protected string _color;
    protected string _name;


    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public Shape(string name, string color)
    {
        _color = color;
        _name = name;
    }

    public virtual double GetArea()
    {
        return 0.0;
    }
}