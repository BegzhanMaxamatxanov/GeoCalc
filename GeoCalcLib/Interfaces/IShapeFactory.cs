namespace GeoCalcLib.Interfaces;

/// <summary>
/// Интерфейс для фабрики фигур.
/// </summary>
public interface IShapeFactory
{
    /// <summary>
    /// Метод для создания фигуры.
    /// </summary>
    /// <param name="parameters">Параметры, необходимые для создания фигуры.</param>
    /// <returns>Экземпляр фигуры.</returns>
    IShape CreateShape(params double[] parameters);
}