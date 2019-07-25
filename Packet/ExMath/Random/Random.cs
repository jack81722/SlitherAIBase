using ExMath.Coordinate;

namespace ExMath.Random
{
    public static class Random
    {
        private static System.Random random = new System.Random();

        public static Vector2 insideUnitCircle
        {
            get
            {
                double angle = random.NextDouble() * 360;
                double x = System.Math.Cos(angle);
                double y = System.Math.Sin(angle);
                return new Vector2((float)x, (float)y);
            }
        }

        public static Vector3 insideUnitSphere
        {
            get
            {
                double x = random.NextDouble();
                double y = random.NextDouble();
                double z = random.NextDouble();
                return Vector3.Normalize(new Vector3((float)x, (float)y, (float)z)) * (float)random.NextDouble();
            }
        }

        public static double Range(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public static float Range(float min, float max)
        {
            return (float)random.NextDouble() * (max - min) + min;
        }

        public static int Range(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}