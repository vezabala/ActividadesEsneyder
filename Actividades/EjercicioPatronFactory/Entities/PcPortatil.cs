using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactory.Entities
{
    internal class PcPortatil : Entity
    {
        public PcPortatil(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro) : base(id, sistemaOperativo, almacenamientoRam, almacenamientoDiscoDuro)
        {
        }
    }
}
