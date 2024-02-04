using GeometryLibrary.Interfaces;

namespace GeometryLibrary;

/// <summary>
/// Provides methods to calculate the area of shapes
/// </summary>
public class AreaCalculator
{
    /// <summary>
    /// Calculate the area of a shape
    /// </summary>
    /// <param name="shape">The shape for which to calculate the area</param>
    /// <returns></returns>
    public static double Calculate(IShape shape) => shape.GetArea();
}