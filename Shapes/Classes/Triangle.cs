using Shapes.Interfaces;

namespace Shapes.Classes
{
    /// <summary>
    /// Класс для работы с треугольником
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <summary>
        /// Конструктор для работы с треугольником
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 && sideC > 0)
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else
            {
                throw new ArgumentException("Длина стороны треугольника должна быть больше 0");
            }
        }

        /// <summary>
        /// Метод получения площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetArea()
        {
            //Формула для получения площади
            //S = √(p(p - a)(p - b)(p - c)), где p — полу периметр
            var p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        /// <summary>
        /// Метод проверки, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>true - прямоугольный, false - нет</returns>
        public bool IsRightTriangle()
        {
            //Формула Пифагора для прямоугольного треугольника
            //с²=a²+b², где с - наибольшая сторона, а и b две других
            double[] sides = { _sideA, _sideB, _sideC };
            //сортируем массив, чтобы узнать наибольшую сторону
            Array.Sort(sides);
            //проверяем, что данные подходят под условия формулы
            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}
