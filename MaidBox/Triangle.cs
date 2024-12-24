using System.Globalization;

namespace MaidBox
{
    public class Triangle : IFigure
    {

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double CalculateArea()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Стороны треугольника должны быть больше 0.");
            }
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new ArgumentException("Сумма длин двух сторон треугольника должна быть больше длины третьей стороны.");
            }

            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightTriangle()
        {
            return (SideA * SideA + SideB * SideB == SideC * SideC)
                   || (SideA * SideA + SideC * SideC == SideB * SideB)
                   || (SideB * SideB + SideC * SideC == SideA * SideA);
        }
    }
}