using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoPersona
{
    public class Persona
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Persona(DateTime birthdate, string name, int age, string lastName, string address)
        {
            BirthDate = birthdate;
            Name = name;
            Age = age;
            LastName = lastName;
            Address = address;
        }

        public Persona()
        {

        }
    }
}
