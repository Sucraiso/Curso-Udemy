using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    class FuncExercicios01
    {
        public void Exercicios01()
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = "+ r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro =  "+ r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)) ;
        }

        public void Exercicios02()
        {
            Pessoas func = new Pessoas();

            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+ func +"\n");

            Console.Write("Digite a porcetagem para aumentar o salário: ");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados: "+ func);
        }

        public void Exercicios03()
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            a.NotaFinalMedia(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            ,double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture)
            ,double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            
            
            Console.WriteLine(a);
        }
    }
}
