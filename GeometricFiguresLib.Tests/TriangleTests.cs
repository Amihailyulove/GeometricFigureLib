namespace GeometricFiguresLib.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(1, 2, 2)]
    public void GetFigureArea_1and2and2_0dot97return(double a, double b, double c)
    {
        IGeometricFigure figure = new Triangle(a, b, c);

        double expected = 0.97;

        double result = figure.GetFigureArea();

        Assert.Equal(expected, result, 0.02);
    }


    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 2, -2)]
    [InlineData(1, 2, 3)]
    [InlineData(3, 1, 2)]
    [InlineData(1, 3, 2)]
    public void Triangle_InvalidArguments_ArgumentExceptionReturn(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }


    [Theory]
    [InlineData(1.451, 2, 2.471)]
    [InlineData(1.7321, 1, 2)]
    [InlineData(1, 2.8284, 3)]
    public void IsRightTriange_RightTriangleSideLenghts_TrueReturn(double a, double b, double c)
    {
        Triangle figure = new(a, b, c);

        bool result = figure.IsRightTriange();

        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    public void IsRightTriange_WrongTriangleSideLenghts_FalseReturn(double a, double b, double c)
    {
        Triangle figure = new(a, b, c);

        bool result = figure.IsRightTriange();

        Assert.False(result);
    }
}
