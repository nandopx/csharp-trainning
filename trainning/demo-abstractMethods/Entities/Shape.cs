using demo_abstractMethods.Entities.Enums;

namespace demo_abstractMethods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape ( Color color)
        {
            Color = color;
        }

        public abstract double Area ();
    }
}
