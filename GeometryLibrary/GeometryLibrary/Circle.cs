using GeometryLibrary.Interfaces;

namespace GeometryLibrary;

/// <summary>
/// Represents a circle shape
/// </summary>
public class Circle : IShape
{
    private double _radius;

    /// <summary>
    /// Constructor for Circle class
    /// </summary>
    /// <param name="radius">The radius of the circle</param>
    public Circle(double radius)
    {
        _radius = radius;
    }

    /// <summary>
    /// Calculate the area of the circle
    /// </summary>
    /// <returns>The area of the circle</returns>
    public double GetArea()
    {
        var s = Math.PI * _radius * _radius;
        return s;
    }
}