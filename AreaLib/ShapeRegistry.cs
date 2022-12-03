using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AreaLib.Shapes;

namespace AreaLib
{
    public class ShapeRegistry
    {
        private Dictionary<string, Type> _shapes;

        public ShapeRegistry()
        {
            _shapes = new Dictionary<string, Type>();
        }

        public void RegisterShape<T>(string? name = null) where T : IShape
        {
            name ??= nameof(T);
            _shapes[name] = typeof(T);
        }

        public string[] GetAvailableShapes()
        {
            return _shapes.Keys.ToArray();
        }

        public double GetArea(string shapeName, double[] shapeParams)
        {
            if (!_shapes.ContainsKey(shapeName))
            {
                throw new ArgumentException("Shape is not registered!");
            }

            var shapeConstructor = _shapes[shapeName].GetConstructor(Type.EmptyTypes);
            if (shapeConstructor?.Invoke(null) is not IShape shape)
            {
                throw new Exception("Something went wrong!");
            }

            return shape.Area(shapeParams);
        }
    }
}
