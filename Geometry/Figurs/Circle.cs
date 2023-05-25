using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IFigure
    {
        private double _radius { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Радиус не должен быть меньше 0");

            _radius = radius;
        }

        public double Area() => Math.PI * _radius * _radius;
    }
}
