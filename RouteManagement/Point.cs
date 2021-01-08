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
            return Math.Sqrt(
                (this._x - nextPoint._x) * (this._x - nextPoint._x) +
                (this._y - nextPoint._y) * (this._y - nextPoint._y)
                );
        }
    }
}
