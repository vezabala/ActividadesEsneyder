using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactory.Entities
{
    internal class Entity
    {
        public int Id { get; protected set; }

        public string SistemaOperativo { get; protected set; }

        public float AlmacenamientoRam { get; protected set; }
        
        public string AlmacenamientoDiscoDuro { get; protected set; }

        public Entity(int id, string sistemaOperativo, float almacenamientoRam, string almacenamientoDiscoDuro)
        {
            Id = id;
            SistemaOperativo = sistemaOperativo;
            AlmacenamientoRam = almacenamientoRam;
            AlmacenamientoDiscoDuro = almacenamientoDiscoDuro;
        }
    }
}
