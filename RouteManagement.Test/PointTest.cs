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
        }
    }
}