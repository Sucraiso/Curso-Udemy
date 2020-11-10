using System;
using System.Collections.Generic;
using System.Text;

namespace Unity_Csharp___Completo.ExercicioComposicao.Entities
{
    class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {}

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            BirthDate = birth;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Client: ");
            sb.Append(Name);
            sb.Append(" (" + BirthDate.ToString("dd/MM/yyyy") + ") - ");
            sb.Append(Email);
            return sb.ToString();
        }
    }
}
