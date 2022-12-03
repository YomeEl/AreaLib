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
        public void ComputeAreaTest()
        {
            Methods.Registry.RegisterShape<TestShape>();
            double area = Methods.ComputeArea("TestShape", Array.Empty<double>());
            Assert.That(area, Is.EqualTo(1.0d).Within(double.Epsilon));
        }
    }
}