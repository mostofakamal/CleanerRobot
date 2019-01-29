using System;

namespace CleanerRobot
{
    public class RobotCommandProvider
    {
        public static Command GetCommand(CommandInput commandInput, IRobotPositioningContext positionContext)
        {
            var steps = commandInput.NoOfSteps;
            switch (commandInput.Direction.ToUpper())
            {
                case "N":
                    return new MoveNorthCommand(steps, positionContext);
                case "S":
                    return new MoveSouthCommand(steps, positionContext);
                case "E":
                    return new MoveEastCommand(steps, positionContext);
                case "W":
                    return new MoveWestCommand(steps, positionContext);
                default:
                    throw new ArgumentException("Invalid Command");

            }
        }
    }
}