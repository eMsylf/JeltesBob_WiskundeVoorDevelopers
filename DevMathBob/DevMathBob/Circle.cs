namespace DevMath
{
    public class Circle
    {
        public Circle() { }

        public Circle(Vector2 position, float radius)
        {
            Position = position;
            Radius = radius;
        }

        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            return (Radius + circle.Radius) >= Vector2.Distance(Position, circle.Position);
        }
    }
}
