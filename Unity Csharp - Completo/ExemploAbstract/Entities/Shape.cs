using Unity_Csharp___Completo.ExemploAbstract.Entities.Enums;

namespace Unity_Csharp___Completo.ExemploAbstract.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
