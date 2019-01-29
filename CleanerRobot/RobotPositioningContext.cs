using System.Collections.Generic;
using System.Linq;

namespace CleanerRobot
{
    public class RobotPositioningContext : IRobotPositioningContext
    {
        private readonly HashSet<KeyValuePair<int, int>> _vertices = new HashSet<KeyValuePair<int, int>>();
        public void AddPosition(Position position)
        {
            _vertices.Add(new KeyValuePair<int, int>(position.X, position.Y));
        }

        public Position GetCurrentPosition()
        {
            return _vertices.Select(x => new Position(x.Key, x.Value)).LastOrDefault();
        }

        public int GetPositionCount()
        {
            return  _vertices.Count;
        }
    }
}