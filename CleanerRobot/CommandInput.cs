namespace CleanerRobot
{
    public class CommandInput
    {
        public CommandInput(string direction, int noOfSteps)
        {
            Direction = direction;
            NoOfSteps = noOfSteps;
        }
        public string Direction { get; private set; }

        public int NoOfSteps { get; private set; }
    }
}