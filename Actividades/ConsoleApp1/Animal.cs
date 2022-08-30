using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal : Entidad
    {
        public string FirstName { get; protected set; }

        public Animal(string name,string firstName):base(name)
        {
            FirstName = firstName;
        }
    }
}
