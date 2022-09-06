using Actividad5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.views.Projects
{
    internal class ProjectView : IVista<Project>
    {
        public void RenderCreate(Project obj)
        {
            Console.WriteLine($"Se a creado el projecto con el id {obj.Id}");
        }

        public void RenderGet(Project obj)
        {
            Console.WriteLine($"id: {obj.Id} - nombre del projecto: {obj.Name} - Nit de la empresa: {obj.Enterprise.Nit}\n");
        }

        public void RenderUpdate(Project obj)
        {
            Console.WriteLine($"Se a actualizado el projecto con el id {obj.Id}");
        }
    }
}
