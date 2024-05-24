using CalculateLibrary.Classes;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary.Tests.Tests
{
    public class TriangleTest
    {
        [Fact]
        //тест на проверку расчета площади треугольника
        public void CalculateLibray_Triangle_CalcSquare()
        {
            //входящие данные для прямоугольного треугольника
            var edgeA = 3;
            var edgeB = 4;
            var edgeC = 5;
            var triangle = new Triangle(edgeA, edgeB, edgeC);

            var halfP = (edgeA + edgeB + edgeC) / 2d;

            //ожидаемый результат
            var expected = Math.Sqrt(halfP * (halfP - edgeA) * (halfP - edgeB) * (halfP - edgeC));

            var square = triangle.CalcSquare();

            //проверяем, удовлетворяет ли ожидаемому результату
            square.Should().Be(expected);
            square.Should().BePositive("Success", Exactly.Once());

        }
    }
}
