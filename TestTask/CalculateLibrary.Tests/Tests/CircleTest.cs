using CalculateLibrary.Classes;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary.Tests.Tests
{
    public class CircleTest
    {
        [Fact]
        //тест на проверку расчета площади круга
        public void CalculateLibray_Circle_CalcSquare()
        {
            //входящие данные
            var radius = 12;

            var circle = new Circle(radius);

            //ожидаемый результат
            var expected = Math.PI * Math.Pow(radius, 2d);

            var square = circle.CalcSquare();

            //проверяем, удовлетворяет ли ожидаемому результату
            square.Should().Be(expected);
            square.Should().BePositive("Success", Exactly.Once());
        }
    }
}
