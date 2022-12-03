using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Unit
{
    internal class TestShape : Shapes.IShape
    {
        public double Area(double[] shapeParams) => -1.0d;
    }

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
            Assert.That(registry.GetArea("TestShape", Array.Empty<double>()), Is.EqualTo(-1.0d));
            
            registry.RegisterShape<TestShape>("OtherName");
            Assert.That(registry.GetAvailableShapes()[1], Is.EqualTo("OtherName"));
            Assert.That(registry.GetArea("OtherName", Array.Empty<double>()), Is.EqualTo(-1.0d));
        }

        [Test]
        public void UnregisteredShapeAreaTest()
        {
            ShapeRegistry registry = new();
            Assert.Throws<ArgumentException>(() =>
                registry.GetArea("UnregisteredShape", Array.Empty<double>())
            );
        }
    }
}