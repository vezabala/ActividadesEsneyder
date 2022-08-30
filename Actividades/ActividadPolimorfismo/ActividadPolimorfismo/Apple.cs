using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPolimorfismo
{
    internal class Apple : Entidad
    {

        public int Presio { get; private set; }
        public Apple(string pantalla, int presio) : base(pantalla)
        {
            Presio = presio;
        }
        public void Comprar()
        {
            Console.WriteLine($"comprar celular apple por ${this.Presio}");
        }
    }
}
