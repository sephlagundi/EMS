using EMS.Models;
using EMS.Repository.InMemory;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class DepartmentController : Controller
    {

        DepartmentInMemoryRepository _repo = new DepartmentInMemoryRepository();

        public IActionResult GetAllDepartments()
        {
            var departmentlist = _repo.GetAllDepartments();
            return View(departmentlist);
        }


        //ADD
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department newDepartment) // model binded this where the views data is accepted 
        {
            if (ModelState.IsValid)
            {
                var department = _repo.AddDepartment(newDepartment);
                return RedirectToAction("GetAllDepartments");
            }
            ViewData["Message"] = "Data is not valid to create the Todo";
            return View();
        }

        //VIEW
        public IActionResult Details(int departmentId)
        {
            var department = _repo.GetDepartmentById(departmentId);
            return View(department);
        }

        //EDIT
        [HttpGet]
        public IActionResult Update(int departmentId)
        {
            var oldDepartment = _repo.GetDepartmentById(departmentId);
            return View(oldDepartment);
        }
        [HttpPost]
        public IActionResult Update(Department newDepartment)
        {
            var department = _repo.UpdateDepartment(newDepartment.DepartmentId, newDepartment);
            return RedirectToAction("GetAllDepartments");
        }


        //DELETE
        public IActionResult Delete(int departmentId)
        {
            var departmentlist = _repo.DeleteDepartment(departmentId);
            return RedirectToAction(controllerName: "Department", actionName: "GetAllDepartments"); // reload the getall page it self
        }
    }
}


