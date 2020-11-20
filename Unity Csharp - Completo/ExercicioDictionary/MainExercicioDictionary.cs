using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Unity_Csharp___Completo.ExercicioDictionary
{
    class MainExercicioDictionary
    {
        public void Exercicio()
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();

            Console.WriteLine("Reading file...");
            using (StreamReader sr = new StreamReader(@"F:\Projetos\Coding\Udemy - C# Completo\Unity Csharp - Completo\Unity Csharp - Completo\ExercicioDictionary\votes.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string name = line[0];
                    int qntVotes = int.Parse(line[1]);

                    if (votes.ContainsKey(name)) 
                    {
                        votes[name] += qntVotes;
                        continue;
                    }

                    votes.Add(name, qntVotes);
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Voting results: ");

            foreach (var obj in votes)
            {
                Console.WriteLine(obj.Key+": "+obj.Value);
            }

        }
    }
}
