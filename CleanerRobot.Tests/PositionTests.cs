using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanerRobot.Tests
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void Create_Position_SpecifyingValues_PositionCreated()
        {
            var position= new Position(10,12);
            Assert.AreEqual(10,position.X);
            Assert.AreEqual(12, position.Y);
        }

        [TestMethod]
        public void Create_Position_WithValueBeyondBoundary_PositionCreatedWithMaxBoundaryLimit()
        {
            var position = new Position(400000, -250000);
            Assert.AreEqual(100000, position.X);
            Assert.AreEqual(-100000, position.Y);
        }
    }
}
