using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad6.Entitys;

namespace Actividad6.Homes
{
    internal class AnimalFoundation<T> : IHome<T> where T : Entidad
    {
        private List<T> InscribedsFoundation { get; set; }

        public AnimalFoundation()
        {
            InscribedsFoundation = new();
        }

        public void Enroll(T obj)
        {
            obj.Id = "1";

            InscribedsFoundation.Add(obj);
        }
    }
}
