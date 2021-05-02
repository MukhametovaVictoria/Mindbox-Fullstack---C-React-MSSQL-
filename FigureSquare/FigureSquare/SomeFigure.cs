namespace FigureSquare
{
    public class SomeFigure : IFigure
    {
        private readonly IFigure figure;

        public SomeFigure(double radius)
        {
            figure = new Circle(radius);
        }

        public SomeFigure(double sideA, double sideB, double sideC)
        {
            figure = new Triangle(sideA, sideB, sideC);
        }

        public double Square => figure.Square;
    }
}