using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square squareShape = new Square("blue", 8.8);
        
        Console.WriteLine($"\n{squareShape.GetColor()}");
        Console.WriteLine($"{squareShape.GetArea()}");

        Circle circleShape = new Circle("green", 5.5);

        Console.WriteLine($"\n{circleShape.GetColor()}");
        Console.WriteLine($"{circleShape.GetArea()}");

        Rectangle rectShape = new Rectangle("pink", 3, 5);

        Console.WriteLine($"\n{rectShape.GetColor()}");
        Console.WriteLine($"{rectShape.GetArea()}");

        shapes.Add(squareShape);
        shapes.Add(circleShape);
        shapes.Add(rectShape);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"\nThe {color} shape has an area of {area}.");
        }
        
    }
}