using Course9.Entities.Enums;

namespace Course9.Entities
{
    abstract class Shapes
    {
        public Color Color { get; set; }

        public Shapes(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
