namespace AreaLib.Shapes
{
    internal class Triangle : IShape
    {
        public double ComputeArea(double[] shapeParams)
        {
            if (shapeParams is null || shapeParams?.Length != 3)
            {
                throw new ArgumentException("Wrong params count!", nameof(shapeParams));
            }

            double a = shapeParams[0];
            double b = shapeParams[1];
            double c = shapeParams[2];
            double s = shapeParams.Sum() / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
    }
}
