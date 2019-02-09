using System.Collections.Generic;

namespace CleanerRobot
{
    public class PositionComparer : IEqualityComparer<Position>
    {
        public bool Equals(Position x, Position y)
        {
            return x.X == y.X && x.Y == y.Y;
        }

        public int GetHashCode(Position obj)
        {
            return (obj.X ^ obj.Y).GetHashCode();
        }
    }
}