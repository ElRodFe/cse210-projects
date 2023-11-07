public class Circle: Shape {
    private double _radius;

    public Circle(string color, double radius) {
        _color = color;
        _radius = radius;
    }

    public override double GetArea() {
        double area = Math.Pow(_radius, 2) * Math.PI;
        return area;
    }
}