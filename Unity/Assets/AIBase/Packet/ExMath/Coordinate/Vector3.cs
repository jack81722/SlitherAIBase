using System;

namespace ExMath.Coordinate
{
    [Serializable]
    public struct Vector3
    {
        public readonly static Vector3 left = new Vector3(-1, 0, 0);
        public readonly static Vector3 right = new Vector3(1, 0, 0);
        public readonly static Vector3 up = new Vector3(0, 1, 0);
        public readonly static Vector3 down = new Vector3(0, -1, 0);
        public readonly static Vector3 forward = new Vector3(0, 0, 1);
        public readonly static Vector3 backward = new Vector3(0, 0, -1);
        public readonly static Vector3 one = new Vector3(1, 1, 1);
        public readonly static Vector3 zero = new Vector3(0, 0, 0);
        
        public float x;
        public float y;
        public float z;
        public float magnitude { get { return (float)Math.Sqrt(x * x + y * y + z * z); } }
        public float sqrMagnitude { get { return x * x + y * y + z * z; } }


        public Vector3(float x, float y)
        {
            this.x = x;
            this.y = y;
            z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static float Dot(Vector3 v1, Vector3 v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.z);
        }

        public static float Angle(Vector3 v1, Vector3 v2)
        {
            return (float)(Math.Acos(Dot(v1, v2) / (v1.magnitude * v2.magnitude)) * 180 / Math.PI);
        }

        public static float SignAngle(Vector3 v1, Vector3 v2)
        {
            var n = Cross(v1, new Vector3(v1.x, v1.y + 1, v1.z));
            if (Dot(Cross(n, v1), v2) / (v1.magnitude * v2.magnitude) >= 0)
                return Angle(v1, v2);
            else
                return -Angle(v1, v2);
        }

        public static float Distance(Vector3 v1, Vector3 v2)
        {
            return (float)Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y) + (v1.z - v2.z) * (v1.z - v2.z));
        }

        public static Vector3 Normalize(Vector3 v)
        {
            return v.magnitude == 0 ? zero : v / v.magnitude;
        }

        public static bool Approach(Vector3 v1, Vector3 v2, float tolerance)
        {
            return System.Math.Abs(v1.x - v2.x) < tolerance && System.Math.Abs(v1.y - v2.y) < tolerance && System.Math.Abs(v1.z - v2.z) < tolerance;
        }

        public static Vector3 Truncate(Vector3 v, float f)
        {
            var n = f;
            n = f / v.magnitude;
            n = n < 1 ? n : 1;
            return v * n;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3 operator *(Vector3 v, float f)
        {
            return new Vector3(v.x * f, v.y * f, v.z * f);
        }

        public static Vector3 operator *(float f, Vector3 v)
        {
            return new Vector3(v.x * f, v.y * f, v.z * f);
        }

        public static Vector3 operator /(Vector3 v, float f)
        {
            return new Vector3(v.x / f, v.y / f, v.z / f);
        }

        public static implicit operator Vector3(Vector2 v)
        {
            return new Vector3(v.x, v.y);
        }

        //public static implicit operator Vector3(Vector3Int v)
        //{
        //    return new Vector3(v.x, v.y, v.z);
        //}

        public override string ToString()
        {
            return string.Format("({0:0.0}, {1:0.0}, {2:0.0})", x, y, z);
        }
    }
}
