using MaidBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Tests
{
    [TestFixture]
    public class FigureFactoryTests
    {
        [Test]
        public void GetFigure_Circle_ReturnsCorrectFigure()
        {
            // Arrange
            var factory = new FigureFactory();

            // Act
            var figure = factory.GetFigure("circle", 5);

            // Assert
            Assert.IsInstanceOf<Circle>(figure);
            Assert.AreEqual(5, ((Circle)figure).Radius);
        }

        [Test]
        public void GetFigure_Triangle_ReturnsCorrectFigure()
        {
            // Arrange
            var factory = new FigureFactory();

            // Act
            var figure = factory.GetFigure("triangle", 3, 4, 5);

            // Assert
            Assert.IsInstanceOf<Triangle>(figure);
            Assert.AreEqual(3, ((Triangle)figure).SideA);
            Assert.AreEqual(4, ((Triangle)figure).SideB);
            Assert.AreEqual(5, ((Triangle)figure).SideC);

        }
    }
}
