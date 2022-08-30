using Actividad3.Hormigas;
using Actividad3.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    internal class HormigaObrera : Hormiga, IHormiguero
    {
        public void Construir()
        {
            Console.WriteLine("contruye hormiguero en cualquien lugar");
        }

        public override void Vigilar()
        {
            Console.WriteLine("Vigila para recolectar objetos para el hormiguero");
        }
    }
}
