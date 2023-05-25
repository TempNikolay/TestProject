using System;
using Xunit;
using Geometry;
using System.Threading.Tasks;

namespace GeomentyTest
{
    public class UnitTest
    {
        IFigure figure;
        IOperator oper;

        [Fact]
        public void TestCircle()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-2));

            figure = new Circle(3);
            oper = new AreaOperator(figure);
            Assert.Equal(28.274333882308138, oper.CalcValue());

            figure = new Circle(5);
            oper = new AreaOperator(figure);
            Assert.Equal(78.53981633974483, oper.CalcValue());
        }

        [Fact]
        public void TestTriangle()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, 3, 5));

            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));

            figure = new Triangle(5, 6, 5);
            oper = new AreaOperator(figure);
            Assert.Equal(12, oper.CalcValue());

            figure = new Triangle(3, 2, 2);
            oper = new AreaOperator(figure);
            Assert.Equal(1.984313483298443, oper.CalcValue());
        }
    }
}
