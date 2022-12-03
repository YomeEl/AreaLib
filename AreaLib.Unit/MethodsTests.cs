using System.Security.Cryptography.X509Certificates;

namespace AreaLib.Unit
{
    [TestFixture]
    public class MethodsTests
    {
        [Test]
        public void BasicShapesPresenceTest()
        {
            string[] shapes = Methods.GetAvailableShapes();
            Assert.That(shapes, Has.Member("Circle").And.Member("Triangle"));
        }

        [Test]
        public void CircleAreaTest()
        {
            double radius = 1.0d;
            double actual = Methods.GetArea("Circle", new double[] { radius });
            double expected = Math.PI * radius * radius;
            
            Assert.That(expected, Is.EqualTo(actual).Within(double.Epsilon));
        }

        [Test]
        public void CircleAreaWrongArgsCount()
        {
            double radius = 1.0d;
            double otherThing = 1.0d;

            double[] args = new double[] { radius, otherThing };

            Assert.That(Methods.GetArea("Circle", args), Is.EqualTo(-1.0d).Within(double.Epsilon));
            Assert.That(Methods.GetLastError(), Is.Not.EqualTo(string.Empty));
        }

        [Test]
        public void TriangleAreaTest()
        {
            double a = 1.0d;
            double b = 1.0d;
            double c = 1.0d;
            double[] sides = new double[] { a, b, c };

            double actual = Methods.GetArea("Triangle", sides);
            double s = sides.Sum() / 2;
            double expected = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            
            Assert.That(expected, Is.EqualTo(actual).Within(double.Epsilon));
        }

        [Test]
        public void TriangleAreaWrongArgsCount()
        {
            double a = 1.0d;
            double b = 1.0d;

            double[] args = new double[] { a, b };

            Assert.That(Methods.GetArea("Triangle", args), Is.EqualTo(-1.0d).Within(double.Epsilon));
            Assert.That(Methods.GetLastError(), Is.Not.EqualTo(string.Empty));
        }
    }
}