using System;

namespace Sorting
{
    public class Point : IMyComparable<Point>
    {
        private readonly int _x;
        private readonly int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private double FindDistanceFromOrigin()
        {
            return Math.Sqrt(_x*_x + _y*_y);
        }


        public int CompareTo(Point otherPoint)
        {
            return FindDistanceFromOrigin().CompareTo(otherPoint.FindDistanceFromOrigin());
        }

        public override string ToString()
        {
            return String.Format("X:{0},Y:{1}", _x, _y);
        }
    }
}
