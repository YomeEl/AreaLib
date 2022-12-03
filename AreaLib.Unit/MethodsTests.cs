using System.Security.Cryptography.X509Certificates;

namespace AreaLib.Unit
{
    public class MethodsTests
    {
        [Test]
        public void CircleAreaTest()
        {
            double radius = 1.0d;
            double actual = Methods.GetArea("circle", new double[] { radius });
            double expected = Math.PI * radius * radius;
            
            Assert.That(expected, Is.EqualTo(actual).Within(double.Epsilon));
        }

        [Test]
        public void TriangleAreaTest()
        {
            double a = 1.0d;
            double b = 1.0d;
            double c = 1.0d;
            double[] sides = new double[] { a, b, c };

            double actual = Methods.GetArea("tirangle", sides);
            double s = sides.Sum() / 2;
            double expected = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            
            Assert.That(expected, Is.EqualTo(actual).Within(double.Epsilon));
        }
    }
}