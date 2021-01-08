using System;
using System.Collections.Generic;
using System.Text;

namespace RouteManagement
{
    public class Point
    {
        private readonly double _x;
        private readonly double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetDistance(Point nextPoint)
        {
            return 0.0;
        }
    }
}
