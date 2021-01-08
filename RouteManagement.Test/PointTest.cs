using NUnit.Framework;

namespace RouteManagement.Test
{
    public class PointTest
    {
        [Test, Sequential]
        public void DistanceTest([Values(0, 1, 0)] double x,
            [Values(0, 0, 1)] double y,
            [Values(0, 1, 1)] double expectedDistance)
        {
            Point referencePoint = new Point(0, 0);
            Point otherPoint = new Point(x, y);
            double distanceFromPoint = referencePoint.GetDistance(otherPoint);
            Assert.AreEqual(expectedDistance, distanceFromPoint, 1e-4);
        }
    }
}