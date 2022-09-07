using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class Employee :Entity
    {
        public string Identification { get; private set; }

        public string Name { get; private set; }

        public Enterprise Enterprise { get; private set; }

        public List<EmployeeProject> EmployeeProject { get; private set; }

        private Employee(string id, string identification, string name, Enterprise enterprise) : base(id)
        {
            Identification = identification;
            Name = name;
            Enterprise = enterprise;
            EmployeeProject = new();
        }

        public static Employee Build(string id, string identification,string name, Enterprise enterprise)
        {
            return new Employee(id, identification,name, enterprise);
        }

        public void AddProject(string projectId)
        {
            this.EmployeeProject.Add(
                new EmployeeProject(
                id: Guid.NewGuid().ToString(),
                employeeId: this.Id,
                projectId: projectId));
        }
    }
}
