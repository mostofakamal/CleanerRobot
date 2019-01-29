using System;

namespace CleanerRobot
{
    public class RobotInputProcessor :  IRobotInputProcessor
    {
        private readonly RobotInput _robotInput;
        private readonly BaseInputHandler _commandCountInputHandler;
        private readonly BaseInputHandler _initialPositionInputHandler;
        private readonly BaseInputHandler _commandInputHandler;
        public RobotInputProcessor()
        {
            _robotInput = new RobotInput();
            _commandCountInputHandler = new CommandCountInputHandler(_robotInput);
            _initialPositionInputHandler = new InitialPositionInputHandler(_robotInput);
            _commandInputHandler = new CommandInputHandler(_robotInput);
            _commandCountInputHandler.SetNextInputHandler(_initialPositionInputHandler);
            _initialPositionInputHandler.SetNextInputHandler(_commandInputHandler);
        }

        public RobotInput TakeAndProcessInput(Func<string> inputReader)
        {
            _commandCountInputHandler.ProcessInput(inputReader());
            _initialPositionInputHandler.ProcessInput(inputReader());
            while (!_commandInputHandler.ProcessInput(inputReader())) { }

            return _robotInput;
        }
    }
}