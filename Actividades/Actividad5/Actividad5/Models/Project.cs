using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    public class Project :Entity
    {
        public string Name { get; private set; }

        public Enterprise Enterprise { get; private set; }

        public List<EmployeeProject> EmployeeProject { get; private set; }

        private Project(string id, string name, Enterprise enterprise) : base(id)
        {
            Name = name;

            Enterprise = enterprise;

            EmployeeProject = new();
        }

        public static Project Build (string id, string name, Enterprise enterprise)
        {
            return new Project(id, name, enterprise);
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
