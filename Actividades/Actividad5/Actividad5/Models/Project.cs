using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class Project :Entity
    {
        public string Name { get; private set; }

        public Enterprise Enterprise { get; private set; }

        public List<EmployeeProject> EmployeeProject { get; private set; }

        public Project(string id, string name, Enterprise enterprise) : base(id)
        {
            Name = name;

            Enterprise = enterprise;

            EmployeeProject = new();
        }
        public void AddEmployee(string EmployeeId, string EmployeeName, Enterprise enterprise)
        {
            this.EmployeeProject.Add(
                new EmployeeProject(
                    id: Guid.NewGuid().ToString(), 
                    employeeId: EmployeeId,
                    projectId: this.Id));
        }
    }
}
