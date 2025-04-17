using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(6, "white");

        Rectangle rectangle = new Rectangle(3, 6, "black");

        Circle circle = new Circle(7, "blue");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.Area();
            Console.WriteLine($"Shape Color: {color}, Area: {area}");
        }
    }
}