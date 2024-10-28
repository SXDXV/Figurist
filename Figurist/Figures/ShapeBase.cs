using Figurist.Figures.Interfaces;

namespace Figurist.Figures
{
    /// <summary>
    /// Абстрактный базовый класс для всех фигур, реализующий интерфейс IShape.
    /// </summary>
    public abstract class ShapeBase : IShape
    {
        /// <summary>
        /// Абстрактный метод для расчета площади фигуры, который должен быть переопределен в каждом конкретном классе фигуры.
        /// </summary>
        /// <returns>Площадь фигуры в виде числа с плавающей точкой.</returns>
        public abstract double GetArea();
    }
}
