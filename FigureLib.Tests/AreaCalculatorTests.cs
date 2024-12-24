using MaidBox;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Tests
{
    public class AreaCalculatorTests
    {
        [Test]
        public void CalculateArea_AnyFigure_CallsFigureCalculateArea()
        {
            // Arrange
            var mockFigure = new Mock<IFigure>();
            var areaCalculator = new AreaCalculator();

            // Act
            areaCalculator.CalculateArea(mockFigure.Object);

            // Assert
            mockFigure.Verify(x => x.CalculateArea(), Times.Once);
        }
    }
}
