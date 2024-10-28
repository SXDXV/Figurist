using Figurist.Figures.Interfaces;

namespace Figurist.Services
{
    /// <summary>
    /// Сервис для вычисления площади фигур, реализующих интерфейс IShape.
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <param name="shape">Объект фигуры, реализующий интерфейс IShape.</param>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}