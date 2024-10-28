using Figurist.Figures;
using Xunit;

namespace Figurist.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_WithValidSides_ReturnsCorrectArea()
        {
            // Тестирует метод GetArea у треугольника с корректными сторонами.
            // Ожидаемый результат: правильная площадь, рассчитанная по формуле Герона.

            // Задаем стороны
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6;

            // Вычисляем площадь
            double actualArea = triangle.GetArea();

            // Проверяем, что рассчитанная площадь совпадает с ожидаемой (с точностью до 5 знаков)
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Constructor_WithInvalidSides_ThrowsArgumentException()
        {
            // Тестирует создание треугольника с недопустимыми сторонами.
            // Ожидаемый результат: ArgumentException, если стороны не могут образовать треугольник.

            // Проверяем, что выбрасывается исключение для сторон, не образующих треугольник
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
            // Проверяем, что выбрасывается исключение для сторон, содержащих 0
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
            // Проверяем, что выбрасывается исключение для отрицательной стороны
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
        }

        [Fact]
        public void IsRightTriangle_WithRightTriangle_ReturnsTrue()
        {
            // Тестирует метод IsRightTriangle для прямоугольного треугольника.
            // Ожидаемый результат: true для треугольника с длинами сторон 3, 4, 5.

            Triangle triangle = new Triangle(3, 4, 5);

            // Проверяем, что метод определяет треугольник как прямоугольный
            bool isRight = triangle.IsRightTriangle();

            Assert.True(isRight);
        }

        [Fact]
        public void IsRightTriangle_WithNonRightTriangle_ReturnsFalse()
        {
            // Тестирует метод IsRightTriangle для не прямоугольного треугольника.
            // Ожидаемый результат: false для треугольника с длинами сторон 5, 6, 7.

            Triangle triangle = new Triangle(5, 6, 7);

            // Проверяем, что метод определяет треугольник как не прямоугольный
            bool isRight = triangle.IsRightTriangle();

            Assert.False(isRight);
        }
    }
}