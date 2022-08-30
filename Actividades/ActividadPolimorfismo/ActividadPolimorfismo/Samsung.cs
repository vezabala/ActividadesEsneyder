using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPolimorfismo
{
    internal class Samsung : Entidad
    {
        public int Presio { get; private set; }
        public Samsung(string pantalla, int presio) : base(pantalla)
        {
            Presio = presio;
        }

        public void Comprar()
        {
            Console.WriteLine($"comprar celular Samsung por ${this.Presio}");
        }
    }
}
