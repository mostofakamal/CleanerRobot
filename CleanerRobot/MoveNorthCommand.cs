namespace CleanerRobot
{
    public class MoveNorthCommand : Command
    {
        public MoveNorthCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override Position AdjustPositionForSingleStep(Position position)
        {
            return new Position(position.X, ++position.Y);
        }
    }
}