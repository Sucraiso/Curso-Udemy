using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioSet.Entities;

namespace Unity_Csharp___Completo.ExercicioSet
{
    class MainExercicioSet
    {
        HashSet<Student> set = new HashSet<Student>();

        public void Exercicio()
        {
            Console.Write("How many students for course A? ");
            ReadEntries(int.Parse(Console.ReadLine()));            

            Console.Write("How many students for course B? ");
            ReadEntries(int.Parse(Console.ReadLine()));

            Console.Write("How many students for course C? ");
            ReadEntries(int.Parse(Console.ReadLine()));

            Console.WriteLine("Total students: "+set.Count);
        }

        private void ReadEntries(int n)
        {
            for (int i = 0; i < n; i++)
            {
                set.Add(new Student(int.Parse(Console.ReadLine())));
            }
        }

        public void ExercicioResolvido()
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
