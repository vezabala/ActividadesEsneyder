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

        public Enterprise Enterprise { get; private set; }

        public List<EmployeeProject> EmployeeProject { get; private set; }

        public Employee(string id, string identification, Enterprise enterprise) : base(id)
        {
            Identification = identification;
            Enterprise = enterprise;
            EmployeeProject = new();
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
