namespace GeometryLibrary.Interfaces;

/// <summary>
/// Interface for shapes that can calculate area
/// </summary>
public interface IShape
{
    /// <summary>
    /// Calculate the area of the shape
    /// </summary>
    /// <returns>The area of the shape</returns>
    double GetArea();
}