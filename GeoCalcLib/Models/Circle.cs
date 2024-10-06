using GeoCalcLib.Interfaces;

namespace GeoCalcLib.Models;

/// <summary>
/// Класс, представляющий круг.
/// </summary>
public class Circle : IShape
{
    public double Radius { get; }

    /// <summary>
    /// Инициализирует новый экземпляр круга.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным", nameof(radius));
        Radius = radius;
    }

    /// <summary>
    /// Возвращает площадь круга.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}