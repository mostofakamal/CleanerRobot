using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanerRobot.Tests
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void Test_CommandCountInputHandler_StringInputProvided_InputParsedCorrectly()
        {
            // Arrange
            var robotInput = new RobotInput();
            var commandCountInputHandler = new CommandCountInputHandler(robotInput);

            // Act
            commandCountInputHandler.ProcessInput("12");

            // Assert
            Assert.AreEqual(12, robotInput.CommandCount);
        }

        [TestMethod]
        public void Test_InitialPositionInputHandler_PositionSetCorrectly()
        {
            // Arrange
            var robotInput = new RobotInput();
            var commandCountInputHandler = new InitialPositionInputHandler(robotInput);

            // Act
            commandCountInputHandler.ProcessInput("10 12");

            // Assert
            Assert.AreEqual(10, robotInput.InitialPosition.X);
            Assert.AreEqual(12, robotInput.InitialPosition.Y);
        }

        [TestMethod]
        public void Test_CommandInputHandler_CommandsAddedCorrectly()
        {
            // Arrange
            var robotInput = new RobotInput()
            {
                CommandCount = 2
            };
            var commandCountInputHandler = new CommandInputHandler(robotInput);

            // Act
            commandCountInputHandler.ProcessInput("S 2");
            commandCountInputHandler.ProcessInput("E 1");

            // Assert
            Assert.AreEqual(2, robotInput.Commands.Count);
            Assert.AreEqual("S", robotInput.Commands[0].Direction);
            Assert.AreEqual(2, robotInput.Commands[0].NoOfSteps);
            Assert.AreEqual("E", robotInput.Commands[1].Direction);
            Assert.AreEqual(1, robotInput.Commands[1].NoOfSteps);

        }

        [TestMethod]
        public void Test_AllInputHandlerConfigured_InputObjectSetCorrectly()
        {
            // Arrange
            var robotInput = new RobotInput();
            var commandCountInputHandler = new CommandCountInputHandler(robotInput);
            var initialPositionInputHandler = new InitialPositionInputHandler(robotInput);
            var commandInputHandler = new CommandInputHandler(robotInput);
            commandCountInputHandler.SetNextInputHandler(initialPositionInputHandler);
            initialPositionInputHandler.SetNextInputHandler(commandInputHandler);

            // Act
            commandCountInputHandler.ProcessInput("2");
            initialPositionInputHandler.ProcessInput("19 4");
            commandInputHandler.ProcessInput("S 6");
            commandInputHandler.ProcessInput("E 1");

            // Assert
            Assert.AreEqual(2, robotInput.CommandCount);
            Assert.AreEqual(19,robotInput.InitialPosition.X);
            Assert.AreEqual(4, robotInput.InitialPosition.Y);
            Assert.AreEqual(2, robotInput.Commands.Count);

        }
    }
}
