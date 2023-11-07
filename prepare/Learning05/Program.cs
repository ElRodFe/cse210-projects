using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 6);
        Rectangle rectangle = new Rectangle("Blue", 3, 6);
        Circle circle = new Circle("Orange", 2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}