using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CleanerRobot.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void Test_MoveNorthCommand_AddPositionCalledCorrectly()
        {
            // Arrange
            var positionContextMock = new Mock<IRobotPositioningContext>();
            positionContextMock.Setup(x => x.GetCurrentPosition()).Returns(new Position(10, 40));
            Command command = new MoveNorthCommand(3, positionContextMock.Object);
            // Act
            command.Execute();
            // Assert
            positionContextMock.Verify(x => x.AddPosition(It.IsAny<Position>()), Times.Exactly(3));
        }

        [TestMethod]
        public void Test_MultipleMoveCommands_AddPositionMethodCalledCorrectly()
        {
            //Arrange
            var positionContextMock = new Mock<IRobotPositioningContext>();
            positionContextMock.Setup(x => x.GetCurrentPosition()).Returns(new Position(10, 40));
            Command moveNorthCommand = new MoveNorthCommand(2, positionContextMock.Object);
            // Act
            moveNorthCommand.Execute();
            Command moveSouthCommand = new MoveEastCommand(4, positionContextMock.Object);
            moveSouthCommand.Execute();

            // Assert
            positionContextMock.Verify(x => x.AddPosition(It.IsAny<Position>()), Times.Exactly(6));
        }

        [TestMethod]
        public void Test_CommandStepsBeyondMinLimit_MinLimitIsSet()
        {
            // Arrange
            var positionContextMock = new Mock<IRobotPositioningContext>();
            positionContextMock.Setup(x => x.GetCurrentPosition()).Returns(new Position(10, 40));
            Command moveNorthCommand = new MoveNorthCommand(-20, positionContextMock.Object);
            moveNorthCommand.Execute();
            positionContextMock.Verify(x => x.AddPosition(It.IsAny<Position>()), Times.Exactly(1));

        }
    }
}
