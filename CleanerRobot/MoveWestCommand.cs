namespace CleanerRobot
{
    public class MoveWestCommand : Command
    {
        public MoveWestCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override Position AdjustPositionForSingleStep(Position position)
        {
            return new Position(--position.X,position.Y);
        }
    }
}