using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanerRobot.Tests
{
    [TestClass]
    public class RobotPositioningContextTests
    {
        [TestMethod]
        public void TestPositionContext_AddTwoPositions_CurrentPositionReturnedOk()
        {
            // Arrange
            var context = new RobotPositioningContext();
            context.AddPosition(new Position(10, 12));
            context.AddPosition(new Position(11, 12));

            // Act
            var currentPosition = context.GetCurrentPosition();
            // Assert
            Assert.AreEqual(11,currentPosition.X);
            Assert.AreEqual(12, currentPosition.Y);
        }

        [TestMethod]
        public void TestPositionContext_AddPositionWithADuplicateOne_OnePositionCountedOnlyOnce()
        {
            // Arrange
            var context = new RobotPositioningContext();
            context.AddPosition(new Position(5, 12));
            context.AddPosition(new Position(5, 13));
            context.AddPosition(new Position(5, 12));

            // Act
            var count = context.GetPositionCount();
            // Assert
            Assert.AreEqual(2,count);
        }
    }
}
