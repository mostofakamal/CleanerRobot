using System;


namespace CleanerRobot.App
{
    class Program
    {

        static void Main(string[] args)
        {
            IRobotInputProcessor inputProcessor = new RobotInputProcessor();
            var input = inputProcessor.TakeAndProcessInput(Console.ReadLine);
            var positionContext = new RobotPositioningContext();
            var robot = new Robot(input, positionContext);
            robot.Run();
            Console.WriteLine(robot.Report());
        }

    }
}
