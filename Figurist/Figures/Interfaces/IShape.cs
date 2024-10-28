using System;

namespace Figurist.Figures.Interfaces
{
    /// <summary>
    /// Интерфейс для всех фигур, поддерживающий расчет площади.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Метод для расчета площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры в виде числа с плавающей точкой.</returns>
        double GetArea();
    }
}
