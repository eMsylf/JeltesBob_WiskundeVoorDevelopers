using System;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
            get
            {
                float a = x * x;
                float b = y * y;
                float c = (float)Math.Sqrt(a + b);
                return c;
            }
        }
        public Vector2 Normalized
        {
            get
            {
                float magnitude = Magnitude;
                float xNormalized = x / magnitude;
                float yNormalized = y / magnitude;
                return new Vector2(xNormalized, yNormalized);
            }
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Distance(Vector2 a, Vector2 b)
        {
            return (b - a).Magnitude;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            // Ik weet niet wat dit voor berekening is maar het is ook cool.
            //float lhsMag = lhs.Magnitude;
            //float rhsMag = rhs.Magnitude;
            //float dot = (lhs.x / lhsMag) * (rhs.x / rhsMag) + (lhs.y / lhsMag) * (rhs.y / rhsMag);
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            float xLerp = a.x + (b.x - a.x) * t;
            float yLerp = a.y + (b.y - a.y) * t;
            return new Vector2(xLerp, yLerp);
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {
            return (float)Math.Atan2(rhs.y - lhs.y, rhs.x - lhs.x);
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            float radians = DevMath.DegToRad(angle);
            float newX = (float)Math.Cos(radians);
            float newY = (float)Math.Sin(radians);
            return new Vector2(newX, newY);
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            float x = lhs.x + rhs.x;
            float y = lhs.y + rhs.y;
            return new Vector2(x, y);
        }
        public static Vector2 operator -(Vector2 v)
        {
            float x = v.x * -1f;
            float y = v.y * -1f;
            return new Vector2(x, y);
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            float x = lhs.x - rhs.x;
            float y = lhs.y - rhs.y;
            return new Vector2(x, y);
        }
        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            float x = lhs.x * scalar;
            float y = lhs.y * scalar;
            return new Vector2(x, y);
        }
        public static Vector2 operator *(float scalar, Vector2 rhs)
        {
            float x = rhs.x * scalar;
            float y = rhs.y * scalar;
            return new Vector2(x, y);
        }
        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            float x = lhs.x / scalar;
            float y = lhs.y / scalar;
            return new Vector2(x, y);
        }
    }
}
