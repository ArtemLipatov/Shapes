using System;
using Shapes.Classes;
using Xunit;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        /// <summary>
        /// Проверяем, что если передавать невалидные данные, то упадет ошибка
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(3, 0, 5)]
        [InlineData(3, 4, 0)]
        [InlineData(-3, 4, 5)]
        [InlineData(3, -4, 5)]
        [InlineData(3, 4, -5)]
        public void InvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        /// <summary>
        /// Проверяем, что метод расчетов площади работает корректно
        /// </summary>
        [Fact]
        public void ValidSides_CalculatesArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actualArea = triangle.GetArea();

            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        /// <summary>
        /// Проверяем, что метод проверки на прямоугольный треугольник работает корректно
        /// </summary>
        [Fact]
        public void ValidSides_IsRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }

        /// <summary>
        /// Проверяем, что если мы передаем стороны не прямоугольного треугольника, то метод вернет корректные значения при проверке
        /// </summary>
        [Fact]
        public void ValidSides_IsNotRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;


            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRightTriangle = triangle.IsRightTriangle();


            Assert.False(isRightTriangle);
        }
    }
}
