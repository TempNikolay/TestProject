using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Абстракция геометрической фигуры.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Вычислить площадь.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double Area();
    }
}
