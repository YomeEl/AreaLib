namespace AreaLib.Unit
{
    [TestFixture]
    internal class BasicShapesTests
    {
        [Test]
        public void CircleWrongArgsCountTest()
        {
            double radius = 1.0d;
            double otherThing = 1.0d;
            double[] args = { radius, otherThing };

            Circle circle = new();

            Assert.Throws<ArgumentException>(() => circle.ComputeArea(args));
            Assert.Throws<ArgumentException>(() => circle.ComputeArea(Array.Empty<double>()));
        }

        [Test]
        public void TriangleWrongArgsCountTest()
        {
            double a = 1.0d;
            double b = 1.0d;
            double c = 1.0d;
            double d = 1.0d;
            double[] args = { a, b, c, d };

            Triangle triangle = new();

            Assert.Throws<ArgumentException>(() => triangle.ComputeArea(args));
            Assert.Throws<ArgumentException>(() => triangle.ComputeArea(Array.Empty<double>()));
        }

        [Test]
        public void CircleAreaTest()
        {
            double radius = 1.0d;
            Circle circle = new();

            double actual = circle.ComputeArea(new double[] { radius });
            double expected = Math.PI * radius * radius;

            Assert.That(expected, Is.EqualTo(actual).Within(double.Epsilon));
        }

        [Test]
        public void TriangleAreaTest()
        {
            double a = 1.0d;
            double b = 1.0d;
            double c = 1.0d;
            double[] args = new double[] { a, b, c };
            Triangle triangle = new();

            double actual = triangle.ComputeArea(args);
            double s = args.Sum() / 2;
            double expected = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Assert.That(expected, Is.EqualTo(actual).Within(double.Epsilon));
        }
    }
}
