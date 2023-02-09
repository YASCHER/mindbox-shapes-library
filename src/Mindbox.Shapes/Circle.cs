namespace Mindbox.Shapes;

public class Circle : Shape
{
    public double Radius { get; }

    public override double CalculateArea() => Math.PI * Radius * Radius;

    public override double CalculatePerimeter() => 2 * Math.PI * Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius));
        }

        Radius = radius;
    }
}
