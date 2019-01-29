namespace CleanerRobot
{
    public class CommandCountInputHandler : BaseInputHandler
    {
        public CommandCountInputHandler(RobotInput input) : base(input)
        {
        }

        public override bool ProcessInput(string input)
        {
            if (Input.CommandCount == 0)
            {
                Input.CommandCount = int.Parse(input);
                return true;
            }

            return NextInputHandler.ProcessInput(input);
        }
    }
}