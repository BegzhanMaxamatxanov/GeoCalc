using GeoCalcLib.Interfaces;
using GeoCalcLib.Models;

namespace GeoCalcLib.Factories;

/// <summary>
/// Фабрика для создания фигур.
/// </summary>
public class ShapeFactory : IShapeFactory
{
    /// <summary>
    /// Создает фигуру на основе переданных параметров.
    /// </summary>
    /// <param name="parameters">Параметры фигуры.</param>
    /// <returns>Фигура.</returns>
    public IShape CreateShape(params double[] parameters)
    {
        if (parameters.Length == 1)
            return new Circle(parameters[0]);
        else if (parameters.Length == 3)
            return new Triangle(parameters[0], parameters[1], parameters[2]);
        else
            throw new ArgumentException("Неподдерживаемое количество параметров для создания фигуры.");
    }
}