namespace CleanerRobot
{
    public class CommandInputHandler : BaseInputHandler
    {
        public CommandInputHandler(RobotInput input) : base(input)
        {
        }

        public override bool ProcessInput(string input)
        {
            if (Input.Commands.Count != Input.CommandCount)
            {
                var commandArray = input.Split(' ');
                Input.Commands.Add(new CommandInput(commandArray[0], int.Parse(commandArray[1])));
                if (Input.Commands.Count == Input.CommandCount)
                {
                    return true;
                }
                return false;
            }

            return true;
        }
    }
}