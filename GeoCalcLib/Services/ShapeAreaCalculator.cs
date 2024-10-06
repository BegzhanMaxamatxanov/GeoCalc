using GeoCalcLib.Interfaces;

namespace GeoCalcLib.Services;

/// <summary>
/// Калькулятор для вычисления площади фигур.
/// </summary>
public class ShapeAreaCalculator
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <param name="shape">Фигура.</param>
    /// <returns>Площадь фигуры.</returns>
    public double CalculateArea(IShape shape)
    {
        return shape.GetArea();
    }
}