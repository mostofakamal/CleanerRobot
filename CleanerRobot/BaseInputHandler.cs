namespace CleanerRobot
{
    public abstract class BaseInputHandler
    {
        protected BaseInputHandler NextInputHandler { get; set; }

        protected RobotInput Input;

        protected BaseInputHandler(RobotInput input)
        {
            Input = input;
        }
        public void SetNextInputHandler(BaseInputHandler next)
        {
            NextInputHandler = next;
        }

        public abstract bool ProcessInput(string input);
    }
}