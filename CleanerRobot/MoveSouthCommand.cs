namespace CleanerRobot
{
    public class MoveSouthCommand : Command
    {
        public MoveSouthCommand(int noOfSteps, IRobotPositioningContext robotPositioningContext) : base(noOfSteps, robotPositioningContext)
        {

        }
        protected override void AdjustPositionForSingleStep(Position position)
        {
            position.Y--;
        }
    }
}