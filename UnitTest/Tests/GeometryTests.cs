using GeoCalcLib.Factories;
using GeoCalcLib.Interfaces;
using GeoCalcLib.Services;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTest.Tests;

public class GeometryTests
{
    private readonly ShapeAreaCalculator _calculator;
    private readonly IShapeFactory _shapeFactory;

    public GeometryTests()
    {
        _calculator = new ShapeAreaCalculator();
        _shapeFactory = new ShapeFactory();
    }

    [Fact]
    public void CircleAreaTest()
    {
        IShape circle = _shapeFactory.CreateShape(5);
        double area = _calculator.CalculateArea(circle);
        Assert.Equal(Math.PI * 25, area, 5);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        IShape triangle = _shapeFactory.CreateShape(3, 4, 5);
        double area = _calculator.CalculateArea(triangle);
        Assert.Equal(6, area, 5);
    }
}