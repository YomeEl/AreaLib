namespace AreaLib.Unit
{
    [TestFixture]
    internal class ShapeRegistryTests
    {
        [Test]
        public void ShapeRegistyTest()
        {
            ShapeRegistry registry = new();
            Assert.That(registry.GetAvailableShapes(), Is.Empty);

            registry.RegisterShape<TestShape>();
            Assert.That(registry.GetAvailableShapes()[0], Is.EqualTo("TestShape"));
            Assert.That(registry.ComputeArea("TestShape", Array.Empty<double>()), Is.EqualTo(1.0d));
            
            registry.RegisterShape<TestShape>("OtherName");
            Assert.That(registry.GetAvailableShapes()[1], Is.EqualTo("OtherName"));
            Assert.That(registry.ComputeArea("OtherName", Array.Empty<double>()), Is.EqualTo(1.0d));
        }

        [Test]
        public void UnregisteredShapeAreaTest()
        {
            ShapeRegistry registry = new();
            Assert.Throws<ArgumentException>(() =>
                registry.ComputeArea("UnregisteredShape", Array.Empty<double>())
            );
        }
    }
}