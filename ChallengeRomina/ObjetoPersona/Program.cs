using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Name = "Marcos";
            persona.LastName = "Fontenla";
            persona.BirthDate = new DateTime(1988, 11, 10);
            persona.Age = 32;
            persona.Address = "CalleFalsa 123";
        }
    }
}
