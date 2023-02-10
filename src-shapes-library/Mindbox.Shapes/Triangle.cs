namespace Mindbox.Shapes;

public class Triangle : Shape
{
    public double A { get; }

    public double B { get; }

    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("All triangle sides must be greater than or equal to 0");
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

    public bool IsRightTriangle(double tolerance = 0.001) 
    {
        bool DoublesIsEqual(double a, double b) => Math.Abs(a - b) < tolerance;

        var isRightTriangle = false;

        // Находим наибольшую сторону и
        // проверяем справедлива ли теорема Пифагора

        if (A > B && A > C)
        {
            isRightTriangle = DoublesIsEqual(A * A, B * B + C * C);
        }
        else if (B > A && B > C)
        {
            isRightTriangle = DoublesIsEqual(B * B, A * A + C * C);
        }
        else if (C > A && C > B)
        {
            isRightTriangle = DoublesIsEqual(C * C, A * A + B * B);
        }

        return isRightTriangle;
    }
}
