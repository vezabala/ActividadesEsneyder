using Actividad5.Models;
using Actividad5.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.controllers
{
    internal class ProjectController
    {
        private IVista<Project> vista;

        public ProjectController(IVista<Project> vista)
        {
            this.vista = vista;
        }

        public void CreateOrUpdate(string option, string id, string name, Enterprise enterprise)
        {
            Project project;

            project = Project.Build(id, name, enterprise);
            if (option.Equals("Create"))
            {
                this.vista.RenderCreate(project);
            }
            else if (option.Equals("Update"))
            {
                this.vista.RenderUpdate(project);
            }
            this.vista.RenderGet(project);
        }
    }
}
