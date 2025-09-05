using Course9.Entities.Enums;

namespace Course9.Entities
{
    class Circle : Shapes
    {
        public double  Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
