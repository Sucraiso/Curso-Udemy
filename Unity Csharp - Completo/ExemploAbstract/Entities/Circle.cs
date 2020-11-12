using System;
using Unity_Csharp___Completo.ExemploAbstract.Entities.Enums;

namespace Unity_Csharp___Completo.ExemploAbstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
