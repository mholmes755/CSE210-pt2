using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        Console.WriteLine("\nShapes Example\n");

        // Store several shapes into a list, then display them

        Square sq1 = new Square("Square", "pink", 1.5);
        Square sq2 = new Square("Square", "violet", 2);
        Square sq3 = new Square("Square", "orange", .75);
        shapes.Add(sq1);
        shapes.Add(sq2);
        shapes.Add(sq3);


        Circle c1 = new Circle("Circle", "blue", 2.5);
        Circle c2 = new Circle("Circle", "red", 13);
        Circle c3 = new Circle("Circle", "yellow", 7.45);
        shapes.Add(c1);
        shapes.Add(c2);
        shapes.Add(c3);

        Rectangle r1 = new Rectangle("Rectablge", "green", 3, 5);
        Rectangle r2 = new Rectangle("Rectangle", "purple", 2, 3.2);
        Rectangle r3 = new Rectangle("Rectangle", "Scarlet", 7, 5.2);
        shapes.Add(r1);
        shapes.Add(r2);
        shapes.Add(r3);


        foreach (Shape shape in shapes)
        {
            string name = shape.GetName();
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{name} Color: {color}, Area: {area:F2}");
        }
    }
}