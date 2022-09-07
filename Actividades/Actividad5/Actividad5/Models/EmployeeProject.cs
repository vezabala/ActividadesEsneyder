using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class EmployeeProject :Entity
    {
        public string EmployeeId { get; private set; }
        public string ProjectId { get; private set; }

        public EmployeeProject(string id,string employeeId, string projectId) :base(id)
        {
            this.EmployeeId = employeeId;
            this.ProjectId = projectId;
        }
    }
}
