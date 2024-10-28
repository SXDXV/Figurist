using Figurist.Figures;
using Xunit;

namespace Figurist.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Тестирует метод GetArea у круга с положительным радиусом.
            // Ожидаемый результат: корректная площадь, рассчитанная по формуле пи * radius в степени 2.

            // Задаем радиус
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Вычисляем площадь
            double actualArea = circle.GetArea();

            // Проверяем, что рассчитанная площадь совпадает с ожидаемой (с точностью до 5 знаков)
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Constructor_WithNonPositiveRadius_ThrowsArgumentException()
        {
            // Тестирует создание круга с неположительным радиусом.
            // Ожидаемый результат: ArgumentException для радиуса 0 или отрицательного значения.

            // Проверяем, что выбрасывается исключение при радиусе 0
            Assert.Throws<ArgumentException>(() => new Circle(0));
            // Проверяем, что выбрасывается исключение при отрицательном радиусе
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}