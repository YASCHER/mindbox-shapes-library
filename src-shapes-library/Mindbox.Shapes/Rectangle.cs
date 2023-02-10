namespace Mindbox.Shapes;

public class Rectangle : Shape
{
    public double A { get; }

    public double B { get; }

    public Rectangle(double a, double b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentException("All rectangle sides must be greater than or equal to 0");
        }

        A = a;
        B = b;
    }

    public override double CalculateArea() => A * B;

    public override double CalculatePerimeter() => 2 * A + 2 * B;
}
