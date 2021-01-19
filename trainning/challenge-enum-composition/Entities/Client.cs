using System;
using System.Collections.Generic;
using System.Text;

namespace challenge_enum_composition.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client () { }

        public Client ( string name, string email, DateTime birthDate )
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString ()
        {
            StringBuilder client = new StringBuilder();
            client.Append( Name );
            client.Append( " (" );
            client.Append( BirthDate.ToString("dd/MM/yyyy") );
            client.Append( ") - " );
            client.AppendLine( Email );

            return client.ToString();
        }
    }
}
