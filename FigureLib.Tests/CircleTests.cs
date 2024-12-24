using MaidBox;

namespace FigureLib.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle { Radius = 5 };

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * 5 * 5, area, 0.0001);
        }

        [Test]
        public void CalculateArea_ZeroOrNegativeRadius_ThrowsException()
        {
            // Arrange
            var circleNegative = new Circle { Radius = -5 };
            var circleZero = new Circle { Radius = 0 };

            // Act && Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => circleNegative.CalculateArea());
            Assert.Throws<ArgumentOutOfRangeException>(() => circleZero.CalculateArea());
        }
    }
}
