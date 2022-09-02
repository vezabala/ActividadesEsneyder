using Actividad6.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Homes
{
    internal class House<T> : IHome<T> where T : Entidad
    {
        private List<T> InscribedsHouse { get; set; }

        public House()
        {
            InscribedsHouse = new();
        }

        public void Enroll(T obj)
        {
            obj.Id = "2";

            InscribedsHouse.Add(obj);
        }
    }
}
