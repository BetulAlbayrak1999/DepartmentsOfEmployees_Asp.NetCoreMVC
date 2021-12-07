using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Controllers
{
    public class PersonController : Controller
    {
        private readonly Context myDbContext;

        public PersonController(Context context)
        {
            myDbContext = context;
        }

       
        public IActionResult Index()
        {
            return View(this.myDbContext.Persons.Include(x => x.Department).ToList());
        }
        [HttpGet]
        public IActionResult NewPerson()
        {
            List<SelectListItem> deps = (from x in myDbContext.Departments.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.DepartmentName,
                                             Value = x.DepartmentId.ToString()
                                         }).ToList();
            ViewBag.departs = deps;
            return View();
        }
        [HttpPost]
        public IActionResult NewPerson(Person person)
        {
            var personDep = myDbContext.Departments.Where(x => x.DepartmentId == person.Department.DepartmentId).FirstOrDefault();
            person.Department = personDep;
            myDbContext.Persons.Add(person);
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePerson(int id)
        {
            var person = myDbContext.Persons.Find(id);
            myDbContext.Persons.Remove(person);
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetPerson(int id)
        {
            var person = myDbContext.Persons.Find(id);
            return View("GetPerson", person);
        }

        public IActionResult UpdatePerson(Person person)
        {
            var per = myDbContext.Persons.Find(person.PersonId);
            per.PersonName = person.PersonName;
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

