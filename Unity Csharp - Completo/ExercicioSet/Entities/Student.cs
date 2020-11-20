using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioSet.Entities
{
    class Student
    {
        public int Code { get; set; }

        public Student(int code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student)) return false;

            Student studant = obj as Student;
            return Code.Equals(studant.Code);
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
    }
}
