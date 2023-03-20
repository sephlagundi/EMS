using EMS.Models;
using EMS.Repository;
using EMS.Repository.InMemory;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeInMemoryRepository _repo = new EmployeeInMemoryRepository();

        public IActionResult GetAllEmployees()
        {
            var employeelist = _repo.GetAllEmployees();
            return View(employeelist);
        }
         public IActionResult Details(int employeeId)
         {
             var employee = _repo.GetEmployeeById(employeeId);
             return View(employee);
         }

        public IActionResult Delete(int employeeId)
        {
            var employeelist = _repo.DeleteEmployee(employeeId);
            return RedirectToAction(controllerName: "Employee", actionName: "GetAllEmployees"); // reload the getall page it self
        }

        // ADD
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee newEmployee) // model binded this where the views data is accepted 
        {
            if (ModelState.IsValid)
            {
                var employee = _repo.AddEmployee(newEmployee);
                return RedirectToAction("GetAllEmployees");
            }
            ViewData["Message"] = "Data is not valid to create the Employee";
            return View();
        }

        //UPDATE
        [HttpGet]
        public IActionResult Update(int employeeId)
        {
            var oldemployee = _repo.GetEmployeeById(employeeId);
            return View(oldemployee);
        }
        [HttpPost]
        public IActionResult Update(Employee newEmployee)
        {
            var employee = _repo.UpdateEmployee(newEmployee.Id, newEmployee);
            return RedirectToAction("GetAllEmployees");
        }
    }
}
