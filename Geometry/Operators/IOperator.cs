using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Абстрактный оператор для вычисления значения.
    /// </summary>
    public interface IOperator
    {
        /// <summary>
        /// Вычислить значение.
        /// </summary>
        /// <returns></returns>
        public double CalcValue();
    }
}
