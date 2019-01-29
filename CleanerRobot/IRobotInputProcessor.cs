using System;

namespace CleanerRobot
{
    public interface IRobotInputProcessor
    {
        RobotInput TakeAndProcessInput(Func<string> inputReader);
    }
}