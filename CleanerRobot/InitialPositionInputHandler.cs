using System;

namespace CleanerRobot
{
    public class InitialPositionInputHandler : BaseInputHandler
    {
        public InitialPositionInputHandler(RobotInput input) : base(input)
        {
        }

        public override bool ProcessInput(string input)
        {
            if (Input.InitialPosition == null)
            {
                var initialPosition = Array.ConvertAll(input.Split(' '), int.Parse);
                Input.InitialPosition = new Position(initialPosition[0], initialPosition[1]);
                return true;
            }

            return NextInputHandler.ProcessInput(input);
        }
    }
}