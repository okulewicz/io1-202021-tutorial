using NUnit.Framework;

namespace RouteManagement.Test
{
    public class PointTest
    {
        [Test]
        public void DistanceTest()
        {
            Point referencePoint = new Point(0, 0);
            double distanceFromSelf = referencePoint.GetDistance(referencePoint);
            Assert.AreEqual(0.0, distanceFromSelf, 1e-4);
            Point horizontalPoint = new Point(1, 0);
            Point verticalPoint = new Point(0, 1);
            double horizontalDistance = referencePoint.GetDistance(horizontalPoint);
            double verticalDistance = referencePoint.GetDistance(verticalPoint);
            Assert.AreEqual(1.0, horizontalDistance, 1e-4);
            Assert.AreEqual(1.0, verticalDistance, 1e-4);
        }
    }
}