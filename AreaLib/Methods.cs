namespace AreaLib
{
    public static class Methods
    {
        public static ShapeRegistry Registry { get; } = Initializer.InitializeShapeRegistry();

        public static string[] GetAvailableShapes()
        {
            return Registry.GetAvailableShapes();
        }

        public static double GetArea(string shapeName, double[] shapeParams)
        {
            return Registry.GetArea(shapeName, shapeParams);
        }

        public static string GetLastError()
        {
            throw new NotImplementedException();
        }
    }
}