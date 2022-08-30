
using Actividad3.Hormigas;
using Actividad3.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.EjercitoHormigas
{
    internal class Ejercito
    {
        private IHormiguero Hormiguero;

        private Hormiga HormigaExplorador;

        private Hormiga HormigaSoldado;

        private IHormiguero HormigaObrera;

        public Ejercito(IHormiguero hormiguero, IHormiguero hormigaObrera)
        {
            Hormiguero = hormiguero;

            this.HormigaExplorador = new HormigaExplorador();

            this.HormigaSoldado = new HormigaSoldado();

            HormigaObrera = hormigaObrera;
        }
    }
}
