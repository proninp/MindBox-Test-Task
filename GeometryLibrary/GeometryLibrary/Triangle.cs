using GeometryLibrary.Interfaces;

namespace GeometryLibrary;

/// <summary>
/// Represents a triangle shape
/// </summary>
public class Triangle : IShape, ITriangle
{
    private double _side1;
    private double _side2;
    private double _side3;

    /// <summary>
    /// The three-sided Triangle constructor
    /// </summary>
    /// <param name="side1">The length of the first side of the triangle</param>
    /// <param name="side2">The length of the second side of the triangle</param>
    /// <param name="side3">The length of the third side of the triangle</param>
    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    /// <summary>
    /// Calculate the area of the triangle
    /// </summary>
    /// <returns>The area of the triangle</returns>
    public double GetArea()
    {
        double hp = GetPerimeter() / 2;
        return Math.Sqrt(hp * (hp - _side1) * (hp - _side2) * (hp - _side3));
    }

    /// <summary>
    /// Calculates the perimeter of the triangle
    /// </summary>
    /// <returns>Triangle's perimeter</returns>
    private double GetPerimeter() => _side1 + _side2 + _side3;

    /// <summary>
    /// Check if the triangle is a rectangular triangle
    /// </summary>
    /// <returns>True if the triangle is rectangular, false otherwiset</returns>
    public bool IsRectangular()
    {
        double[] sides = { _side1, _side2, _side3 };
        Array.Sort(sides);
        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }
}