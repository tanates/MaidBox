using MaidBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area, 0.0001);
        }
        [Test]
        public void CalculateArea_InvalidTriangle_ThrowsArgumentException()
        {
            // Arrange
            var triangle = new Triangle { SideA = 1, SideB = 1, SideC = 5 };

            // Act && Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }


        [Test]
        public void CalculateArea_InvalidZeroSides_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var triangle = new Triangle { SideA = 0, SideB = 4, SideC = 5 };
            var triangle2 = new Triangle { SideA = 3, SideB = 0, SideC = 5 };
            var triangle3 = new Triangle { SideA = 3, SideB = 4, SideC = 0 };

            // Act && Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.CalculateArea());
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle2.CalculateArea());
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle3.CalculateArea());
        }

        [Test]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };


            // Act
            bool isRight = triangle.IsRightTriangle();
            // Assert
            Assert.IsTrue(isRight);

        }

        [Test]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle { SideA = 3, SideB = 5, SideC = 7 };

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRight);
        }
    }
}
