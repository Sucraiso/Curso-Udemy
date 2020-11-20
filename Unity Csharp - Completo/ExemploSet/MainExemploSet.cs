using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Unity_Csharp___Completo.ExemploSet.Entities;

namespace Unity_Csharp___Completo.ExemploSet
{
    class MainExemploSet
    {
        public void Exercicio()
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Acessing file... ");
            string path = @"F:\Projetos\Coding\Udemy - C# Completo\Unity Csharp - Completo\Unity Csharp - Completo\ExemploSet\in.txt";
            Console.WriteLine();
            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(" ");
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord { Username = name, Instant = instant });                    
                }
                Console.WriteLine("Total users: "+set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
