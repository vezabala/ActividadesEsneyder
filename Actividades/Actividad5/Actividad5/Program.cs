using Actividad5.controllers;
using Actividad5.Models;
using Actividad5.views.Employees;
using Actividad5.views.Projects;

//Employee
EmployeeController employeeController = new EmployeeController (new EmployeeView());

employeeController.CreateOrUpdate("Create","1", "123456789","Jorge", Enterprise.Build("1", "123"));

employeeController.CreateOrUpdate("Update","1", "123456789","Jorge Andres", Enterprise.Build("1", "123"));

Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////\n");

//Project
ProjectController projectController = new ProjectController(new ProjectView());

projectController.CreateOrUpdate("Create","2", "Proyecto 1", Enterprise.Build("1", "123"));

projectController.CreateOrUpdate("Update", "2", "Proyecto 1 Modificado", Enterprise.Build("1", "123"));