
namespace CleanerRobot
{
    public abstract class Command
    {
        private const int MaxAllowedSteps = 100000;
        private int _noOfSteps;
        protected readonly IRobotPositioningContext RobotPositioningContext;
        protected Command(int noOfSteps, IRobotPositioningContext robotPositioningContext)
        {
             ValidateAndSetStepCount(noOfSteps);
            RobotPositioningContext = robotPositioningContext;
        }

        private void ValidateAndSetStepCount(int steps)
        {
            if (steps <= 0)
            {
                this._noOfSteps = 1;
            }
            else if (steps > MaxAllowedSteps)
            {
                this._noOfSteps = MaxAllowedSteps;
            }
            else
            {
                this._noOfSteps = steps;
            }
        }
        protected abstract Position AdjustPositionForSingleStep(Position position);

        public void Execute()
        {
            var position = GetCurrentPosition();
            for (var i = 0; i < _noOfSteps; i++)
            {
                var newPosition= AdjustPositionForSingleStep(position);
                RobotPositioningContext.AddPosition(newPosition);
            }
        }

        private Position GetCurrentPosition()
        {
            return RobotPositioningContext.GetCurrentPosition();
        }
    }
}