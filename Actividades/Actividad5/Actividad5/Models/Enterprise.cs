using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class Enterprise :Entity
    {
        public string Nit { get; private set; }

        public List<Employee> Employees { get; private set; }

        public List<Project> Projects { get; private set; }

        public Enterprise(string id, string nit) : base(id)
        {
            Nit = nit;

            Employees = new();

            Projects = new();
        }

        public void AddEmployees(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void AddProjects(Project project)
        {
            this.Projects.Add(project);
        }
    }
}
