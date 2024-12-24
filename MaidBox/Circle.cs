namespace MaidBox
{
    public class Circle : IFigure
    {

        public double Radius { get; set; }
        public double CalculateArea()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Radius), "Радиус должен быть больше 0");
            }
            return Math.PI * Radius * Radius;
        }

    }
}