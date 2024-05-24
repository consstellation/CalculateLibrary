using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateLibrary.Interfaces;

namespace CalculateLibrary.Classes
{
    public class Circle
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        /// <param name="radius">радус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Неверно указан радиус круга", nameof(radius));
            Radius = radius;
        }

        /// <summary>
        /// Расчет площади квадрата
        /// </summary>
        /// <returns></returns>
        public double CalcSquare() => Math.PI * Math.Pow(Radius, 2d);

    }
}
