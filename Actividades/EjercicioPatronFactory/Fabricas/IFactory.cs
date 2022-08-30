using EjercicioPatronFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactory.Fabricas
{
    internal interface IFactory
    {
        public Entity buildPcPortatil(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro);

        public Entity buildPcMesa(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro, string marcaDispositivoTeclado, string marcaDispositivoMouse, string marcaDispositivoPantalla);
    }
}
