using System;

namespace Figurist.Figures
{
    /// <summary>
    /// Класс, представляющий круг и предоставляющий метод для расчета его площади.
    /// </summary>
    public class Circle : ShapeBase
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Создает экземпляр круга с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));

            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга по формуле π * radius^2.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}