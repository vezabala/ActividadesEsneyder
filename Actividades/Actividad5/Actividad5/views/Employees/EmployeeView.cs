using Actividad5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.views.Employees
{
    internal class EmployeeView : IVista<Employee>
    {
        //Create
        public void RenderCreate(Employee obj)
        {
            Console.WriteLine($"Se a creado el empleado con el numero de identificacion {obj.Identification}");
        }

        public void RenderGet(Employee obj)
        {
            Console.WriteLine($"id: {obj.Id} - identificacion: {obj.Identification} - nombre: {obj.Name} - Nit empresa: {obj.Enterprise.Nit}\n");
        }

        //Update
        public void RenderUpdate(Employee obj)
        {
            Console.WriteLine($"Se a actualizado el empleado con el numero de identificacion {obj.Identification}");
        }
    }
}
