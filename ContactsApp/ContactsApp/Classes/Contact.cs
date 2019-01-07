using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string cityCode { get; set; }
        public string city { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Surname} - {Email} - {Street}- {city} - {cityCode}- {Phone}";
        }

    }
}
