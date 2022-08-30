using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactory.Entities
{
    internal class PcMesa : Entity
    {
        public string MarcaDispositivoTeclado { get; set; }

        public string MarcaDispositivoMouse { get; set; }

        public string MarcaDispositivoPantalla { get; set; }
        public PcMesa(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro, string marcaDispositivoTeclado, string marcaDispositivoMouse, string marcaDispositivoPantalla) : base(id, sistemaOperativo, almacenamientoRam, almacenamientoDiscoDuro)
        {
            MarcaDispositivoMouse = marcaDispositivoTeclado;
            MarcaDispositivoMouse = marcaDispositivoMouse;
            MarcaDispositivoPantalla = marcaDispositivoPantalla;
        }
    }
}
