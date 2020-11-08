using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo
{
    class Employee
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee ( int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double porcentage)
        {
            Salary += Salary * porcentage / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
