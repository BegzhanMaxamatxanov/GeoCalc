namespace GeoCalcLib.Interfaces;

/// <summary>
/// Общий интерфейс для всех геометрических фигур.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Возвращает площадь фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    double GetArea();
}