namespace MaidBox
{

  

    public interface IFigureFactory
    {
        IFigure GetFigure(string figureType, params double[] parameters);
    }
    public class FigureFactory : IFigureFactory
    {
        public IFigure GetFigure(string figureType, params double[] parameters)
        {
            switch (figureType.ToLower())
            {
                case "circle":
                    if (parameters.Length != 1) throw new ArgumentException("Для круга должен быть один параметр - радиус");
                    return new Circle { Radius = parameters[0] };
                case "triangle":
                    if (parameters.Length != 3) throw new ArgumentException("Для треугольника должно быть три параметра - стороны");
                    return new Triangle { SideA = parameters[0], SideB = parameters[1], SideC = parameters[2] };
                default: throw new ArgumentException("Фигура не определена");
            }
        }
    }
}
