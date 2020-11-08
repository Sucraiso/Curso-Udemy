using System;

namespace Unity_Csharp___Completo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2.0) + (Altura * 2.0);
        }

        public double Diagonal()
        {
            return MathF.Sqrt(MathF.Pow((float)Altura, 2.0f) + MathF.Pow((float)Largura, 2.0f));
        }
    }
}
