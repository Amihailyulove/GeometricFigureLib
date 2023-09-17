namespace GeometricFiguresLib;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IGeometricFigure
{
    private double SideA { get; set; }
    private double SideB { get; set; }
    private double SideC { get; set; }

    /// <exception cref="AggregateException">
    /// <list type="bullet">
    /// <item>Сторона треугольника не может быть меньше 0 или равна 0</item>
    /// <item>Длина любой стороны треугольника должна быть меньше суммы длин двух других сторон.</item>
    /// </list>
    /// </exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        Validate();
    }

    /// <summary>
    /// Проверяет длины сторон треугольника на корректность.
    /// </summary>
    /// <exception cref="AggregateException">
    /// <list type="bullet">
    /// <item>Сторона треугольника не может быть меньше 0 или равна 0</item>
    /// <item>Длина любой стороны треугольника должна быть меньше суммы длин двух других сторон.</item>
    /// </list>
    /// </exception>
    private void Validate()
    {
        if (SideA <= 0 || SideB <= 0 || SideC <= 0)
        {
            throw new ArgumentException(
                $"Сторона треугольника не может быть меньше 0 или равна 0. Текущие длины сторон: {SideA}; {SideB}; {SideC}.");
        }

        if (SideA >= SideB + SideC)
        {
            throw new ArgumentException(
                $"Длина любой стороны треугольника должна быть меньше суммы длин двух других сторон." +
                $" {SideA} <= {SideB} + {SideC}. {SideB} + {SideC} = {SideB + SideC}.");
        }

        if (SideB >= SideA + SideC)
        {
            throw new ArgumentException(
                $"Длина любой стороны треугольника должна быть меньше суммы длин двух других сторон." +
                $" {SideB} <= {SideA} + {SideC}. {SideA} + {SideC} = {SideA + SideC}.");
        }

        if (SideC >= SideA + SideB)
        {
            throw new ArgumentException(
                $"Длина любой стороны треугольника должна быть меньше суммы длин двух других сторон." +
                $" {SideC} <= {SideA} + {SideB}. {SideA} + {SideB} = {SideA + SideB}.");
        }
    }

    /// <summary>
    /// Рассчитывает площадь треугольника по заданным длинам трех сторон.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public double GetFigureArea()
    {
        double semiperimeter = (SideA + SideB + SideC) / 2;

        double area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));

        return area;
    }

    /// <summary>
    /// Проверяет является ли треугольник прямоугольным.
    /// </summary>
    /// <returns>true, если прямоугольник является прямоугольным, в противном случае — false.</returns>
    /// <remarks>Вычисления проходят с точностью 3 знака после запятой</remarks>
    public bool IsRightTriange()
    {
        // Погрешность измерений
        double measurementError = 0.001;

        bool isSideARightTriangle = Math.Abs(Math.Pow(SideA, 2) - (Math.Pow(SideB, 2) + Math.Pow(SideC, 2))) <= measurementError;
        bool isSideBRightTriangle = Math.Abs(Math.Pow(SideB, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideC, 2))) <= measurementError;
        bool isSideCRightTriangle = Math.Abs(Math.Pow(SideC, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideB, 2))) <= measurementError;

        return isSideARightTriangle || isSideBRightTriangle || isSideCRightTriangle;
    }
}
