using Actividad3.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Hormigas
{
    internal class HormigaSoldado : Hormiga
    {
        public override void Vigilar()
        {
            Console.WriteLine("La hormiga Soldado vigila para atacar");
        }
    }
}
