namespace CleanerRobot
{
    public class MoveEastCommand : Command
    {
        public MoveEastCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override void AdjustPositionForSingleStep(Position position)
        {
            position.X++;
        }
    }
}