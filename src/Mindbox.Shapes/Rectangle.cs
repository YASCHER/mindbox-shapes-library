namespace Mindbox.Shapes;

public class Rectangle : Shape
{
    public double A { get; }

    public double B { get; }

    public Rectangle(double a, double b)
    {
        if (a <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        else if (b <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(b));
        }

        A = a;
        B = b;
    }

    public override double CalculateArea() => A * B;

    public override double CalculatePerimeter() => 2 * A + 2 * B;
}
