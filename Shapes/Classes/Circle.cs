using Shapes.Interfaces;

namespace Shapes.Classes
{
    /// <summary>
    /// Класс для работы с кругом
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        /// <summary>
        /// Конструктор для создания круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус круга не может быть отрицательным");
            }
            _radius = radius;
        }

        /// <summary>
        /// Метод получения площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
