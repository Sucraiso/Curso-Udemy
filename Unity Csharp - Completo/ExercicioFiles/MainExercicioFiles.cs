using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace Unity_Csharp___Completo.ExercicioFiles
{
    class MainExercicioFiles
    {
        public void Exercicio()
        {
            string[] import = File.ReadAllLines(@"F:\Projetos\Coding\Udemy - C# Completo\Unity Csharp - Completo\Unity Csharp - Completo\ExercicioFiles\itens.csv");
            string export = @"F:\Projetos\Coding\Udemy - C# Completo\Unity Csharp - Completo\Unity Csharp - Completo\ExercicioFiles\out\summary.csv";


            foreach (string txt in import)
            {
                string[] aux = txt.Split(',');
                string name = aux[0].Substring(1);
                double price = double.Parse(aux[1].ToString(),CultureInfo.InvariantCulture);
                int quant = int.Parse(aux[2].Remove(1));

                double total = price * quant;

                using(StreamWriter sw = new StreamWriter(export, true, Encoding.UTF8))
                {
                    sw.WriteLine(name+","+ total.ToString("F2",CultureInfo.InvariantCulture));
                }
            }

            foreach (string txt in import) Console.WriteLine(txt);
            Console.WriteLine();

            using (StreamReader sr = new StreamReader(export))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
