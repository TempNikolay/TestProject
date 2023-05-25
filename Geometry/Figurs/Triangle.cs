using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Geometry
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Треугльник является прямоугольным.
        /// </summary>
        public bool IsStraight
        {
            get
            {
                double sqA = _a * _a;
                double sqB = _b * _b;
                double sqC = _c * _c;

                return sqA + sqB == sqC || sqC + sqA == sqB || sqB + sqC == sqA;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Triangle(double a, double b, double c)
        {
            #region Проверка
            if (a < 0) throw new ArgumentOutOfRangeException(nameof(a), "Длина стороны не должна быть отрицательной");
            if (b < 0) throw new ArgumentOutOfRangeException(nameof(b), "Длина стороны не должна быть отрицательной");
            if (c < 0) throw new ArgumentOutOfRangeException(nameof(c), "Длина стороны не должна быть отрицательной");
            if (a + b <= c || c + a <= b || b + c <= a) throw new ArgumentException("Нарушено неравенство треугольника");
            #endregion

            _a = a;
            _b = b;
            _c = c;
        }

        public double Area()
        {
            double p = (_a + _b + _c) * 0.5;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
