using EjercicioPatronFactory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactory.Fabricas
{
    internal class Factory : IFactory
    {
        public Entity buildPcMesa(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro, string marcaDispositivoTeclado, string marcaDispositivoMouse, string marcaDispositivoPantalla)
        {
            return new PcMesa(id,sistemaOperativo,almacenamientoRam,almacenamientoDiscoDuro,marcaDispositivoTeclado,marcaDispositivoMouse,marcaDispositivoPantalla);
        }

        public Entity buildPcPortatil(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro)
        {
            return new PcPortatil(id, sistemaOperativo, almacenamientoRam, almacenamientoDiscoDuro);
        }
    }
}
