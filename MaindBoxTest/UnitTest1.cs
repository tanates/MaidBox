using MaidBox;
using NUnit.Framework;
using Moq;
namespace MaidBox.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void AreaCounting_ValidTriangle_CalculatesAreaCorrectly()
        {
            // Arrange
            var triangle = new Triangle();
            var sides = new double[] { 3, 4, 5 };

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); //Перенаправляем консольный вывод
                                    // Act
                triangle.AreaCounting(sides);

                // Assert
                string expectedOutput = "square = 6 right triangle : True";
                Assert.AreEqual(expectedOutput, sw.ToString().Trim());
            }
        }


        [Test]
        public void AreaCounting_ValidNotRightTriangle_CalculatesAreaCorrectly()
        {
            // Arrange
            var triangle = new Triangle();
            var sides = new double[] { 3, 5, 7 };

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                // Act
                triangle.AreaCounting(sides);


                // Assert
                string expectedOutput = "square = 6.49519052838329 right triangle : False";
                Assert.AreEqual(expectedOutput, sw.ToString().Trim());
            }
        }


        [Test]
        public void AreaCounting_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            var triangle = new Triangle();
            var sides = new double[] { 3, 4 };


            // Act + Assert
            Assert.Throws<ArgumentException>(() => triangle.AreaCounting(sides));
        }
    }
}