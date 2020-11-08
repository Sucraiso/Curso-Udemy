using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Unity_Csharp___Completo
{
    static class List_Exercicio
    {
        public static void Exercicio()
        {
            List<Employee> employ = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employ.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employ.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employ)
            {
                Console.WriteLine(obj);

            }
        }
    }
}



