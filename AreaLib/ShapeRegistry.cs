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
            Type type = typeof(T);
            name ??= type.Name;
            _shapes[name] = type;
        }

        public string[] GetAvailableShapes()
        {
            return _shapes.Keys.ToArray();
        }

        public double ComputeArea(string shapeName, double[] shapeParams)
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

            return shape.ComputeArea(shapeParams);
        }
    }
}
