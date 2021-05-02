using System;

namespace FigureSquare
{
    public class Triangle : IFigure
    {
        private readonly double sideA, sideB, sideC;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            sideA = firstSide;
            sideB = secondSide;
            sideC = thirdSide;
        }

        public double Square
        {
            get
            {
                if (this.IsExist())
                {
                    double p = (sideA + sideB + sideC) / 2;
                    return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                }
                return Double.NaN;
            }
        }

        public bool IsRightTriangle()
        {
            if (this.IsExist())
            {
                return sideA == Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) ||
                   sideB == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2)) ||
                   sideC == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            }
            return false;
        }

        public bool IsExist()
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                //throw new Exception("Такого треугольника не существует(сторона(ы) меньше 0)");
                return false;
            }

            if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
            {
                //throw new Exception("Такого треугольника не существует(сторона больше или равна сумме двух других)");
                return false;
            }

            return true;
        }
    }
}
