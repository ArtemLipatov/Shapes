using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Interfaces
{
    /// <summary>
    /// Интерфейс фигуры, его должны использовать все фигуры
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Метод получения площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        double GetArea();
    }
}
