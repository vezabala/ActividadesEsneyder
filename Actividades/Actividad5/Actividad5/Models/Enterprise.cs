using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    public class Enterprise :Entity
    {
        public string Nit { get; private set; }

        public List<Employee> Employees { get; private set; }

        public List<Project> Projects { get; private set; }

        private Enterprise(string id, string nit) : base(id)
        {
            Nit = nit;

            Employees = new();

            Projects = new();
        }

        public static Enterprise Build(string id, string nit)
        {
            return new Enterprise(id, nit);
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
