using System;

namespace CleanerRobot
{
    public class Position
    {
        public Position(int x, int y)
        {  
            X = x;
            Y = y;

        }

        private int _x;
        private int _y;
        private int ValidateAndGetValue(int value)
        {
            return Math.Min(Math.Max(PositionBoundary.LowerBound, value), PositionBoundary.UpperBound);
        }

        public int X
        {
            get => _x;
            set => _x= ValidateAndGetValue(value);
        }

        public int Y
        {
            get => _y;
            set => _y= ValidateAndGetValue(value);
        }

       


    }
}