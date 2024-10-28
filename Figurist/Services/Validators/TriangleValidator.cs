using Figurist.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurist.Services.Validators
{
    /// <summary>
    /// Сервис для проверки свойств треугольника.
    /// </summary>
    public class TriangleValidator
    {
        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="triangle">Объект треугольника.</param>
        /// <returns>Истина, если треугольник прямоугольный; иначе ложь.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если объект не является треугольником.</exception>
        public bool IsRightTriangle(ShapeBase triangle)
        {
            if (triangle is Triangle concreteTriangle)
            {
                return concreteTriangle.IsRightTriangle();
            }

            throw new ArgumentException("Объект не является треугольником.");
        }
    }
}