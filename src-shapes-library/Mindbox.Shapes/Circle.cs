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
            throw new ArgumentException("A circle radius must be greater than or equal to 0");
        }

        R = r;
    }
}
