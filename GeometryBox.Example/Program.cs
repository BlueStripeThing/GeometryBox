using GeometryBox.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        CheckCircleArea(3.42);
        CheckTriangleArea(4.543, 6.12, 7.12);
    }

    private static void CheckCircleArea(double radius)
    {
        var circle = new Circle(radius);
        Console.WriteLine(circle.ToString());
    }

    private static void CheckTriangleArea(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Console.WriteLine(triangle.ToString());
        Console.WriteLine($"Is this triagle a Right one? {triangle.IsRightAngled()}");
    }
}