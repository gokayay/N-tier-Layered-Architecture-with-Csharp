using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierLA.Entities
{
    public class ContactsRegistration
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Telephone1 { get; set; }

        public string Telephone2 { get; set; }

        public string Telephone3 { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Definition { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}

