using GeoCalcLib.Interfaces;

namespace GeoCalcLib.Models;

/// <summary>
/// Класс, представляющий треугольник.
/// </summary>
public partial class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    /// <summary>
    /// Инициализирует новый экземпляр треугольника.
    /// </summary>
    /// <param name="sideA">Первая сторона.</param>
    /// <param name="sideB">Вторая сторона.</param>
    /// <param name="sideC">Третья сторона.</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        ValidateSides(sideA, sideB, sideC);

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private void ValidateSides(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Все стороны треугольника должны быть положительными");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Треугольник с такими сторонами не может существовать.");
    }

    /// <summary>
    /// Возвращает площадь треугольника по формуле Герона.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public double GetArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns>True, если треугольник прямоугольный.</returns>
    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}