using CalculateLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary.Classes
{
    public class Triangle: IFigureTriangle
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double EdgeA { get; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double EdgeB { get; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double EdgeC { get; }

        /// <summary>
        /// конструктор класса Triangle
        /// </summary>
        /// <param name="edgeA"> сторона A</param>
        /// <param name="edgeB"> сторона B</param>
        /// <param name="edgeC"> сторона C</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA < 0)
                throw new ArgumentException("Неверно указана сторона", nameof(edgeA));

            if (edgeB < 0)
                throw new ArgumentException("Неверно указана сторона", nameof(edgeB));

            if (edgeC < 0)
                throw new ArgumentException("Неверно указана сторона", nameof(edgeC));

            if (edgeA + edgeB <= edgeC || edgeA + edgeC <= edgeB || edgeB + edgeC <= edgeA)
                throw new ArgumentException("Это не треугольник");

            if (!(edgeA * edgeA + edgeB * edgeB == edgeC * edgeC) || (edgeA * edgeA + edgeC * edgeC == edgeB * edgeB) || (edgeC * edgeC + edgeB * edgeB == edgeA * edgeA))
                throw new ArgumentException("Треугольник  не прямоугольный");

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

        }

        /// <summary>
        /// расчет площади треугольника
        /// </summary>
        /// <returns></returns>
        public double CalcSquare()
        {
            double halfP = (EdgeA + EdgeB + EdgeC) / 2d;

            double squareTriangle = Math.Sqrt(halfP * (halfP - EdgeA) * (halfP - EdgeB) * (halfP - EdgeC));

            return squareTriangle;
        }


    }
}
