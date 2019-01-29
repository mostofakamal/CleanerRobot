using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanerRobot.Tests
{
    [TestClass]
    public class RobotCommandProviderTests
    {
        [TestMethod]
        public void Test_RobotCommandFactory_ProvideCommandInput_RelatedCommandIsReturned()
        {
            var input = new CommandInput("S",2);
            var southCommand= RobotCommandProvider.GetCommand(input, new RobotPositioningContext());
            Assert.AreEqual(typeof(MoveSouthCommand),southCommand.GetType());

            var input2 = new CommandInput("E", 2);
            var eastCommand = RobotCommandProvider.GetCommand(input2, new RobotPositioningContext());
            Assert.AreEqual(typeof(MoveEastCommand), eastCommand.GetType());

            var input3 = new CommandInput("N", 4);
            var northCommand = RobotCommandProvider.GetCommand(input3, new RobotPositioningContext());
            Assert.AreEqual(typeof(MoveNorthCommand), northCommand.GetType());

        }
    }
}
