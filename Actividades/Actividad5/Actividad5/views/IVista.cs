using Actividad5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.views
{
    internal interface IVista<T> where T : Entity
    {
        public void RenderCreate(T obj);
        public void RenderUpdate(T obj);
        public void RenderGet(T obj);
    }
}
