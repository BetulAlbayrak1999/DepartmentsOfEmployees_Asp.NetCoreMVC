using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly Context myDbContext;

        public DepartmentController(Context context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(this.myDbContext.Departments.ToList());
        }
        [HttpGet]
        public IActionResult NewDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewDepartment(Department department)
        {
            myDbContext.Departments.Add(department);
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDepartment(int id)
        {
            var dep = myDbContext.Departments.Find(id);
            myDbContext.Departments.Remove(dep);
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetDepartment(int id)
        {
            var department = myDbContext.Departments.Find(id);
            return View("GetDepartment", department);
        }

        public IActionResult UpdateDepartment(Department department)
        {
            var dep = myDbContext.Departments.Find(department.DepartmentId);
            dep.DepartmentName = department.DepartmentName;
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmentDetail(int id) {
            var persons = myDbContext.Persons.Where(x => x.DepartmentId == id).ToList();
            var departmentName = myDbContext.Departments.Where(x => x.DepartmentId == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.depName = departmentName;
            return View(persons);
        }
    }
}
