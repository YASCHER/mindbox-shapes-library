namespace Mindbox.Shapes;

public class Circle : Shape
{
    public double R { get; }

    public override double CalculateArea() => Math.PI * R * R;

    public override double CalculatePerimeter() => 2 * Math.PI * R;

    public Circle(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(r));
        }

        R = r;
    }
}
