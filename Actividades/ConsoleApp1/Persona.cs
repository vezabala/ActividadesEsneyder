using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona : Entidad
    {
        public string FirstName { get; private set; }

        public Persona(string name, string firstName):base(name)
        {
            this.FirstName = firstName;
        }
    }
}
