namespace GeometricFiguresLib.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(5)]
    public void GetFigureArea_5_78dot54Return(double radius)
    {
        IGeometricFigure figure = new Circle(radius);
        double expected = 78.54;

        double result = figure.GetFigureArea();

        Assert.Equal(expected, result, 0.002);
    }

    [Theory]
    [InlineData(-1)]
    public void Circle_Minus1_ArgumentExceptionReturn(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}