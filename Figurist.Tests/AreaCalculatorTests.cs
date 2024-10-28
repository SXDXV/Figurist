using Figurist.Figures;
using Figurist.Services;
using Xunit;

namespace Figurist.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_WithCircle_ReturnsCorrectArea()
        {
            // Тестирует метод CalculateArea для круга.
            // Ожидаемый результат: корректная площадь для круга с радиусом 5.

            // Задаем радиус круга
            double radius = 5;
            Circle circle = new Circle(radius);
            AreaCalculator calculator = new AreaCalculator();
            double expectedArea = Math.PI * radius * radius;

            // Вычисляем площадь через сервис
            double actualArea = calculator.CalculateArea(circle);

            // Проверяем, что рассчитанная площадь совпадает с ожидаемой (с точностью до 5 знаков)
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void CalculateArea_WithTriangle_ReturnsCorrectArea()
        {
            // Тестирует метод CalculateArea для треугольника.
            // Ожидаемый результат: правильная площадь для треугольника со сторонами 3, 4 и 5.

            // Задаем стороны треугольника
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            AreaCalculator calculator = new AreaCalculator();
            double expectedArea = 6;

            // Вычисляем площадь через сервис
            double actualArea = calculator.CalculateArea(triangle);

            // Проверяем, что рассчитанная площадь совпадает с ожидаемой (с точностью до 5 знаков)
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }
    }
}