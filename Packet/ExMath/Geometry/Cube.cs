using System;
using ExMath.Coordinate;

namespace ExMath.Geometry
{
    [Serializable]
    public struct Cube
    {
        public Vector3 center;
        public Vector3 size;

        public float xMin { get { return Math.Min(center.x - size.x / 2, center.x + size.x / 2); } }
        public float yMin { get { return Math.Min(center.y - size.y / 2, center.y + size.y / 2); } }
        public float zMin { get { return Math.Min(center.z - size.z / 2, center.z + size.z / 2); } }
        public Vector3 min { get { return new Vector3(xMin, yMin, zMin); } }
        public float xMax { get { return Math.Max(center.x - size.x / 2, center.x + size.x / 2); } }
        public float yMax { get { return Math.Max(center.y - size.y / 2, center.y + size.y / 2); } }
        public float zMax { get { return Math.Max(center.z - size.z / 2, center.z + size.z / 2); } }
        public Vector3 max { get { return new Vector3(xMax, yMax, zMax); } }
        public float volume { get { return size.magnitude; } }

        public Cube(float x, float y, float z, float xSize, float ySize, float zSize)
        {
            center = new Vector3(x, y, z);
            size = new Vector3(xSize, ySize, zSize);
        }

        public Cube(float x, float y, float z, Vector3 size)
        {
            center = new Vector3(x, y, z);
            this.size = size;
        }

        public Cube(Vector3 center, float xSize, float ySize, float zSize)
        {
            this.center = center;
            size = new Vector3(xSize, ySize, zSize);
        }

        public Cube(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public bool inBound(Vector3 pos)
        {
            return (pos.x >= xMin && pos.x <= xMax) && (pos.y >= yMin && pos.y <= yMax) && (pos.z >= zMin && pos.z <= zMax);
        }

        public static bool isIntersect(Cube a, Cube b)
        {
            Vector3 aMin = a.min;
            Vector3 aMax = a.max;
            Vector3 bMin = b.min;
            Vector3 bMax = b.max;

            return (aMin.x <= bMax.x && aMax.x >= bMin.x) &&
                (aMin.y <= bMax.y && aMax.y >= bMin.y) &&
                (aMin.z <= bMax.z && aMax.z >= bMin.z);
        }

        public static bool isIntersect(Cube cube, Sphere sphere)
        {
            Vector3 closest = new Vector3(
                    Math.Max(cube.xMin, Math.Min(sphere.center.x, cube.xMax)),
                    Math.Max(cube.yMin, Math.Min(sphere.center.y, cube.yMax)),
                    Math.Max(cube.zMin, Math.Min(sphere.center.z, cube.zMax)));

            float sqrDist =
                (closest.x - sphere.center.x) * (closest.x - sphere.center.x) +
                (closest.y - sphere.center.y) * (closest.y - sphere.center.y) +
                (closest.z - sphere.center.z) * (closest.z - sphere.center.z);

            return sqrDist <= sphere.radius * sphere.radius;
        }

        public static bool isIntersect(Sphere sphere, Cube cube)
        {
            return isIntersect(cube, sphere);
        }
    }
}
