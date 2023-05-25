using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Класс-оператор для вычисления площади фигур.
    /// </summary>
    public class AreaOperator : IOperator
    {
        IFigure _figure;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="figure">Геометрическая фигура</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AreaOperator(IFigure figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure), "Объект фигуры не должен быть null");

            _figure = figure;
        }

        /// <summary>
        /// Вычислить площадь.
        /// </summary>
        /// <returns></returns>
        public double CalcValue()
        {
            return _figure.Area();
        }
    }
}
