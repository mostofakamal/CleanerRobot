using System.Collections.Generic;
using System.Linq;

namespace CleanerRobot
{
    public class RobotPositioningContext : IRobotPositioningContext
    {
        private readonly List<Position> _vertices = new List<Position>();
        public void AddPosition(Position position)
        {
            _vertices.Add(position);
        }

        public Position GetCurrentPosition()
        {
            return _vertices.LastOrDefault();
        }

        public int GetPositionCount()
        {
            return _vertices.Distinct(new PositionComparer()).Count();
        }
    }
}