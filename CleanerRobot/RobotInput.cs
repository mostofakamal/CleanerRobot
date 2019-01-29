using System.Collections.Generic;

namespace CleanerRobot
{
    public class RobotInput
    {
        public RobotInput()
        {
            Commands = new List<CommandInput>();
        }
        public int CommandCount { get; set; }

        public Position InitialPosition { get; set; }

        public List<CommandInput> Commands { get; set; }
    }
}