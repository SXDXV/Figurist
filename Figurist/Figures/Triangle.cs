using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurist.Figures
{
    /// <summary>
    /// Класс, представляющий треугольник и предоставляющий метод для расчета его площади.
    /// </summary>
    public class Triangle : ShapeBase
    {
        /// <summary>
        /// Длина первой стороны треугольника.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Длина второй стороны треугольника.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Длина третьей стороны треугольника.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Создает экземпляр треугольника с заданными длинами сторон.
        /// </summary>
        /// <param name="sideA">Длина первой стороны.</param>
        /// <param name="sideB">Длина второй стороны.</param>
        /// <param name="sideC">Длина третьей стороны.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Все стороны должны быть положительными числами.");

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Сумма длин любых двух сторон должна быть больше длины третьей стороны.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public override double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным, используя теорему Пифагора.
        /// </summary>
        /// <returns>Истина, если треугольник прямоугольный; иначе ложь.</returns>
        public bool IsRightTriangle()
        {
            double aSquared = Math.Pow(SideA, 2);
            double bSquared = Math.Pow(SideB, 2);
            double cSquared = Math.Pow(SideC, 2);

            return AlmostEqual(aSquared + bSquared, cSquared) ||
                   AlmostEqual(aSquared + cSquared, bSquared) ||
                   AlmostEqual(bSquared + cSquared, aSquared);
        }

        /// <summary>
        /// Проверяет, образуют ли заданные длины сторон допустимый треугольник.
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        /// <returns>Истина, если стороны могут образовать треугольник; иначе ложь.</returns>
        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// Проверка на равенство с заданной точностью для сравнения вещественных чисел.
        /// </summary>
        private static bool AlmostEqual(double x, double y, double epsilon = 1e-10)
        {
            return Math.Abs(x - y) < epsilon;
        }
    }
}