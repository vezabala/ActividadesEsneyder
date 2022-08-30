using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Hormigas
{
    internal abstract class Hormiga
    {
        public void Comer()
        {
            Console.WriteLine("La hormiga come por la boca");
        }
        public void Respirar()
        {
            Console.WriteLine("La hormiga respira por los espiraculos");
        }
        public abstract void Vigilar();
    }
}
