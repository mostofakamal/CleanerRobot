namespace CleanerRobot
{
    public class MoveNorthCommand : Command
    {
        public MoveNorthCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override void AdjustPositionForSingleStep(Position position)
        {
            position.Y++;
        }
    }
}