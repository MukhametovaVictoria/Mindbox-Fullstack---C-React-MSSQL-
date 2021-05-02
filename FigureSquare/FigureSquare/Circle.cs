using System;

namespace FigureSquare
{
    public class Circle : IFigure
    {
        private readonly double circleRadius;

        public Circle(double radius)
        {
            circleRadius = radius;
        }

        public double Square => Math.PI * Math.Pow(circleRadius, 2);
    }
}
