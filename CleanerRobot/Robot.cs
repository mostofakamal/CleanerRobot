using System.Collections.Generic;

namespace CleanerRobot
{
    public class Robot
    {
        private readonly IRobotPositioningContext _robotPositioningContext;

        private readonly List<Command> _commands = new List<Command>();

        public Robot(RobotInput input, IRobotPositioningContext positioningContext)
        {
            _robotPositioningContext = positioningContext;
            Configure(input);
        }

        private void Configure(RobotInput input)
        {
            _robotPositioningContext.AddPosition(input.InitialPosition);
            foreach (var command in input.Commands)
            {
                AddCommand(RobotCommandProvider.GetCommand(command, _robotPositioningContext));
            }
        }
        public void Run()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void AddCommand(Command command)
        {
            _commands.Add(command);
        }

        public string Report()
        {
            return $"=> Cleaned: {_robotPositioningContext.GetPositionCount()}" ;
        }
    }
}
