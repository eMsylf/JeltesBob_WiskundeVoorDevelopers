using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            float a = startVelocity * time;
            float b = acceleration * time * time;
            return a + b * .5f;
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public static float RadToDeg(float angle)
        {
            // 180/Pi
            return 57.2957795131f * angle;
        }

        public static float DegToRad(float angle)
        {
            // Pi/180
            return 0.01745329251f * angle;
        }
    }
}
