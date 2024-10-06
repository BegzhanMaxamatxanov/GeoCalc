using GeoCalcLib.Factories;
using GeoCalcLib.Interfaces;
using GeoCalcLib.Models;
using GeoCalcLib.Services;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        IShapeFactory shapeFactory = new ShapeFactory();
        ShapeAreaCalculator calculator = new ShapeAreaCalculator();

        IShape circle = shapeFactory.CreateShape(5);
        IShape triangle = shapeFactory.CreateShape(3, 4, 5);

        Console.WriteLine($"Площадь круга: {calculator.CalculateArea(circle)}");
        Console.WriteLine($"Площадь треугольника: {calculator.CalculateArea(triangle)}");

        Triangle tri = triangle as Triangle;
        if (tri != null && tri.IsRightTriangle())
        {
            Console.WriteLine("Треугольник является прямоугольным.");
        }
    }
}