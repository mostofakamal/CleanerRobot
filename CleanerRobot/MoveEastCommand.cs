namespace CleanerRobot
{
    public class MoveEastCommand : Command
    {
        public MoveEastCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override Position AdjustPositionForSingleStep(Position position)
        {
            return new Position(++position.X, position.Y);
        }
    }
}