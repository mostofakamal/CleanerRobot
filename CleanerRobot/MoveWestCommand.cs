namespace CleanerRobot
{
    public class MoveWestCommand : Command
    {
        public MoveWestCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override void AdjustPositionForSingleStep(Position position)
        {
            position.X--;
        }
    }
}