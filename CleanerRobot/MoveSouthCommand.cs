namespace CleanerRobot
{
    public class MoveSouthCommand : Command
    {
        public MoveSouthCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override Position AdjustPositionForSingleStep(Position position)
        {
            return new Position(position.X, --position.Y);
        }
    }
}