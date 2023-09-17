namespace GeometricFiguresLib;

public class Circle : IGeometricFigure
{
    private double Radius { get; set; }

    /// <exception cref="ArgumentException">Радиус меньше 0.</exception>
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException($"Радиус круга не может быть меньше 0. Текущее значение {Radius}.");
        }

        Radius = radius;
    }

    /// <summary>
    /// Рассчитывает площадь круга по заданному радиусу.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public double GetFigureArea()
    {
        double area = Math.PI * Math.Pow(Radius, 2);

        return area;
    }
}
