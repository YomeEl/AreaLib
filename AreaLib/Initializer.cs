namespace AreaLib
{
    internal static class Initializer
    {
        public static ShapeRegistry InitializeShapeRegistry()
        {
            ShapeRegistry shapeRegistry = new();
            shapeRegistry.RegisterShape<Shapes.Circle>();
            shapeRegistry.RegisterShape<Shapes.Triangle>();
            return shapeRegistry;
        }
    }
}
