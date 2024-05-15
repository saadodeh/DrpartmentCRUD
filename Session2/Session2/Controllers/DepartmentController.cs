using Microsoft.AspNetCore.Mvc;
using Session2.Data;
using Session2.Models;

namespace Session2.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentContext context=new DepartmentContext();

        public IActionResult Index()
        {
            var departments = context.Departments.ToList();
            return View("Index",departments);
        }
        public IActionResult Details(int Id)
        {
            //return Content($"ID :{Id}");
            var department = context.Departments.Find(Id);
            return View("Details",department);
        }
        public IActionResult Create() { return View("Create"); }
        public IActionResult Store(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var department = context.Departments.Find(Id);
            context.Departments.Remove(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}
