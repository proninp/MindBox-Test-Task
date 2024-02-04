namespace GeometryLibrary.Tests;

public class GeometryTests
{
    [Theory]
    [InlineData(5, 78.54)]
    [InlineData(10, 314.16)]
    public void CircleAreaCalculationTest(double radius, double expectedArea)
    {
        Circle circle = new Circle(radius);
        double area = circle.GetArea();
        Assert.Equal(expectedArea, area, 2);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 8, 10, 24)]
    public void TriangleAreaCalculationTest(double side1, double side2, double side3, double expectedArea)
    {
        Triangle triangle = new Triangle(side1, side2, side3);
        double area = triangle.GetArea();
        Assert.Equal(expectedArea, area, 2);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 6, 7, false)]
    public void IsRectangularTriangleTest(double side1, double side2, double side3, bool expectedIsRectangular)
    {
        Triangle triangle = new Triangle(side1, side2, side3);
        bool isRectangular = triangle.IsRectangular();
        Assert.Equal(expectedIsRectangular, isRectangular);
    }
}