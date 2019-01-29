using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanerRobot.Tests
{
    [TestClass]
    public class RobotTests
    {
        [TestMethod]
        public void Test_RobotMoveEastCommandAndThenGetReport_ReportReturnedExactNoOfCleanedCount()
        {
            // Arrange
            var positionService = new RobotPositioningContext();
            var robotInput= new RobotInput()
            {
                InitialPosition = new Position(10,2)
            };
            var robot =new Robot(robotInput,positionService);
            robot.AddCommand(new MoveEastCommand(2,positionService));
            // Act
            robot.Run();
            var result = robot.Report();

            // Assert
            Assert.AreEqual("=> Cleaned: 3", result);
        }

        [TestMethod]
        public void Test_RobotInputAndThenRunAndFinallyGetReport_ReportOK()
        {
            // Arrange
            var input = new RobotInput()
            {
                InitialPosition = new Position(10, 12),
                CommandCount = 3,
                Commands = new List<CommandInput>()
                {
                    new CommandInput("N", 5),
                    new CommandInput("E", 1),
                    new CommandInput("S", 1)
                }
            };
            var positionContext = new RobotPositioningContext();
            var robot = new Robot(input, positionContext);

            // Act
            robot.Run();
            var totalNoOfPositionsCleaned = positionContext.GetPositionCount();
            var report = robot.Report();

            // Assert
            Assert.AreEqual(8, totalNoOfPositionsCleaned);
            Assert.AreEqual("=> Cleaned: 8", report);

        }
    }
}
