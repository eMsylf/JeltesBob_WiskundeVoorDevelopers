using System;

namespace DevMath
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public float Magnitude
        {
            get
            {
                float a = x * x;
                float b = y * y;
                float c = z * z;
                float d = z * z;
                float e = (float)Math.Sqrt(a + b + c + d);
                return e;
            }
        }

        public Vector4 Normalized
        {
            get
            {
                float magnitude = Magnitude;
                float xNormalized = x / magnitude;
                float yNormalized = y / magnitude;
                float zNormalized = z / magnitude;
                float wNormalized = w / magnitude;
                return new Vector4(xNormalized, yNormalized, zNormalized, wNormalized);
            }
        }

        public Vector4(float x, float y, float z, float w = 1f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator Vector4(Vector3 v)
        {
            return new Vector4(v.x, v.y, v.z, 1f);
        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            float xLerp = a.x + (b.x - a.x) * t;
            float yLerp = a.y + (b.y - a.y) * t;
            float zLerp = a.z + (b.z - a.z) * t;
            float wLerp = a.w + (b.w - a.w) * t;
            return new Vector4(xLerp, yLerp, zLerp, wLerp);
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            float x = lhs.x + rhs.x;
            float y = lhs.y + rhs.y;
            float z = lhs.z + rhs.z;
            float w = lhs.w + rhs.w;
            return new Vector4(x, y, z, w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            float x = lhs.x - rhs.x;
            float y = lhs.y - rhs.y;
            float z = lhs.z - rhs.z;
            float w = lhs.w - rhs.w;
            return new Vector4(x, y, z, w);
        }

        public static Vector4 operator -(Vector4 v)
        {
            float x = v.x * -1f;
            float y = v.y * -1f;
            float z = v.z * -1f;
            float w = v.w * -1f;
            return new Vector4(x, y, z, w);
        }

        public static Vector4 operator *(Vector4 lhs, float scalar)
        {
            float x = lhs.x * scalar;
            float y = lhs.y * scalar;
            float z = lhs.z * scalar;
            float w = lhs.w * scalar;
            return new Vector4(x, y, z, w);
        }

        public static Vector4 operator *(float scalar, Vector4 rhs)
        {
            float x = rhs.x * scalar;
            float y = rhs.y * scalar;
            float z = rhs.z * scalar;
            float w = rhs.w * scalar;
            return new Vector4(x, y, z, w);
        }

        public static Vector4 operator /(Vector4 lhs, float scalar)
        {
            float x = lhs.x / scalar;
            float y = lhs.y / scalar;
            float z = lhs.z / scalar;
            float w = lhs.w / scalar;
            return new Vector4(x, y, z, w);
        }
    }
}
