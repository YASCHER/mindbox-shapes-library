namespace Mindbox.Shapes;

public class Triangle : Shape
{
    public double A { get; }

    public double B { get; }

    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        else if (b <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(b));
        }
        else if (c <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(c));
        }
        else if (a >= b + c || b >= a + c || c >= a + b)
        {
            throw new ArgumentException("A triangle with specified sides does not exist");
        }

        A = a;
        B = b;
        C = c;
    }

    public override double CalculateArea()
    {
        var p = CalculatePerimeter() / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override double CalculatePerimeter() => A + B + C;
}
