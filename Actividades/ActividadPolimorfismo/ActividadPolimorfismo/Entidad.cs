using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPolimorfismo
{
    internal abstract class Entidad
    {
        public string Pantalla { get; protected set; }
        protected Entidad( string pantalla)
        {
            Pantalla = pantalla;
        }
        public void encenderPantalla()
        {
            Console.WriteLine($"Prender {Pantalla}");
        }
        public void apagarPantalla()
        {
            Console.WriteLine($"apagar {Pantalla}");
        }
    }
}
