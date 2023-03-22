using Shapes.Classes;
using System;
using Xunit;

namespace Shapes.Tests
{
    public class CircleTests
    {
        /// <summary>
        /// Тест для проверки, что площадь высчитывается правильно
        /// </summary>
        [Fact]
        public void ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            var correctArea = Math.PI * radius * radius;
            Circle circle = new Circle(radius);

            double area = circle.GetArea();

            Assert.Equal(correctArea, area);
        }

        /// <summary>
        /// Тест проверки, что если передадим невалидные данные, упадет ошибка
        /// </summary>
        [Fact]
        public void NegativeRadius_ThrowsArgumentException()
        {
            double radius = -5;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
