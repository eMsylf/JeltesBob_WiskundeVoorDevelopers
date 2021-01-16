using System;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }


        public float mass = 1.0f; // mass
        public float force = 150f; // force
        public float dragCoefficient = .47f; // drag
        

        public void AddForce(Vector2 forceDirection, float deltaTime)
        {
            //Math.E;
            // a = (force / mass) * deltaTime
            // velocity = (1/drag) * ( e^(-(drag/mass) * deltaTime)) * (drag * velocity + mass * a) - (mass * a) / drag


            //forceDirection = new Vector2((forceDirection.x * Velocity.x * deltaTime), (forceDirection.y * Velocity.y * deltaTime));

            float acceleration = (force / mass) * deltaTime;
            Velocity =
                (1 / dragCoefficient) * (float)Math.Exp((-dragCoefficient / mass) * deltaTime) * ((dragCoefficient * Velocity) + (mass * acceleration * forceDirection))
                - ((mass * acceleration * forceDirection) / dragCoefficient);
        }
    }
}
