namespace CleanerRobot
{
    public interface IRobotPositioningContext
    {
        void AddPosition(Position position);
        Position GetCurrentPosition();
        int GetPositionCount();
    }
}