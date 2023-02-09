using Mindbox.Shapes.UnitTests.Fixtures;
using Xunit;

namespace Mindbox.Shapes.UnitTests;

public class ShapeTests : IClassFixture<ShapeTestsFixture>
{
    private readonly ShapeTestsFixture _fixture;

    public ShapeTests(ShapeTestsFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData(5, 78.539)]
    [InlineData(3, 28.274)]
    [InlineData(4.11, 53.068)]
    [InlineData(124.98, 49071.678)]
    public void CircleAreaTheory(double radius, double expectedArea)
    {
        var circle = new Circle(radius);

        var area = circle.CalculateArea();

        Assert.True(Math.Abs(area - expectedArea) < _fixture.Tolerance);
    }

    [Theory]
    [InlineData(7, 43.982)]
    [InlineData(3, 18.849)]
    public void CirclePerimeterTheory(double radius, double expectedPerimeter)
    {
        var circle = new Circle(radius);

        var perimeter = circle.CalculatePerimeter();

        Assert.True(Math.Abs(perimeter - expectedPerimeter) < _fixture.Tolerance);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    [InlineData(int.MinValue)]
    [InlineData(-3.3)]
    public void CircleAreaInvalidArgumentTheory(double radius)
    {
        try
        {
            var circle = new Circle(radius);
        }
        catch (ArgumentOutOfRangeException)
        {
            Assert.True(radius <= 0);
        }
    }
}