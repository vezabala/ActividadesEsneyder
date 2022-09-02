using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad6.Entitys;

namespace Actividad6.Homes
{
    internal interface IHome<T> where T : Entidad
    {
        public void Enroll(T obj);
    }
}
