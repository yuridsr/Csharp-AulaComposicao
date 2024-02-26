using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder S = new StringBuilder();

            S.Append("Client: ");
            S.Append(Name);
            S.Append(" (");
            S.Append(BirthDate.ToString("dd/MM/yyyy"));
            S.Append(") - ");
            S.Append(Email);
            return S.ToString();
        }

    }
}
