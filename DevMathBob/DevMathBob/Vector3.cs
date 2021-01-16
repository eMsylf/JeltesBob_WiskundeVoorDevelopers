using System;

namespace DevMath
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public float Magnitude
        {
            get
            {
                float a = x * x;
                float b = y * y;
                float c = z * z;
                float d = (float)Math.Sqrt(a + b + c);
                return d;
            }
        }

        public Vector3 Normalized
        {
            get
            {
                float magnitude = Magnitude;
                float xNormalized = x / magnitude;
                float yNormalized = y / magnitude;
                float zNormalized = z / magnitude;
                return new Vector3(xNormalized, yNormalized, zNormalized);
            }
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(Vector2 v)
        {
            return new Vector3(v.x, v.y, 0f);
        }

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
            float x = lhs.y * rhs.z - lhs.z* rhs.y;
            float y = lhs.z * rhs.x - lhs.x* rhs.z;
            float z = lhs.x * rhs.y - lhs.y * rhs.x;
            return new Vector3(x, y, z);
            //throw new NotImplementedException();
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            float xLerp = a.x + (b.x - a.x) * t;
            float yLerp = a.y + (b.y - a.y) * t;
            float zLerp = a.z + (b.z - a.z) * t;
            return new Vector3(xLerp, yLerp, zLerp);
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            float x = lhs.x + rhs.x;
            float y = lhs.y + rhs.y;
            float z = lhs.z + rhs.z;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            float x = lhs.x - rhs.x;
            float y = lhs.y - rhs.y;
            float z = lhs.z - rhs.z;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator -(Vector3 v)
        {
            float x = v.x * -1f;
            float y = v.y * -1f;
            float z = v.z * -1f;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
            float x = lhs.x * scalar;
            float y = lhs.y * scalar;
            float z = lhs.z * scalar;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator *(float scalar, Vector3 rhs)
        {
            //return rhs * scalar;
            float x = rhs.x * scalar;
            float y = rhs.y * scalar;
            float z = rhs.z * scalar;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
            float x = lhs.x / scalar;
            float y = lhs.y / scalar;
            float z = lhs.z / scalar;
            return new Vector3(x, y, z);
        }
    }
}
