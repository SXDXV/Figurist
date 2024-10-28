using System;

namespace Figurist.Utils
{
    /// <summary>
    /// Вспомогательный класс с математическими методами.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Сравнивает два вещественных числа с заданной точностью.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <param name="epsilon">Допустимое отклонение для равенства (по умолчанию 1e-10).</param>
        /// <returns>Истина, если числа равны с учетом допустимого отклонения; иначе ложь.</returns>
        public static bool AlmostEqual(double x, double y, double epsilon = 1e-10)
        {
            return Math.Abs(x - y) < epsilon;
        }
    }
}