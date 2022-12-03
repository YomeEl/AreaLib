namespace AreaLib
{
    public static class Methods
    {
        public static ShapeRegistry Registry { get; } = Initializer.InitializeShapeRegistry();

        public static string[] GetAvailableShapes()
        {
            throw new NotImplementedException();
        }

        public static double GetArea(string shapeName, double[] shapeParams)
        {
            throw new NotImplementedException();
        }

        public static string GetLastError()
        {
            throw new NotImplementedException();
        }
    }
}