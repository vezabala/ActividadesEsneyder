using Actividad5.Models;
using Actividad5.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.controllers
{
    internal class EmployeeController
    {
        private readonly IVista<Employee> vista;

        public EmployeeController(IVista<Employee> vista)
        {
            this.vista = vista;
        }

        public void CreateOrUpdate(string option,string id, string identification,  string name, Enterprise enterprise)
        {
            Employee employee;

            employee = Employee.Build(id, identification, name , enterprise);
            if (option.Equals("Create"))
            {
                this.vista.RenderCreate(employee);  
            }
            else if (option.Equals("Update"))
            {
                this.vista.RenderUpdate(employee);
            }
            this.vista.RenderGet(employee);
        }
    }
}
