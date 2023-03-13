using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FristApp.Models;
using FristApp.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FristApp.Controllers
{
    public class StudentController : Controller
    {
        //Dependentcy data injection
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }


        // GET: /<controller>/
        public IActionResult StudentIndex()
        {
            IEnumerable<Student> allStudent = _db.Students;

            return View(allStudent);

        }
        //return viwe page
        public IActionResult StudentCreate()
        {
            return View();
        }
        //Get method post and save data to database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StudentCreate(Student obj)
        {
            if (ModelState.IsValid) //Check data to will input
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("StudentIndex");
            }
            return View(obj);

        }
        public IActionResult StudentAbout()
        {
            return View();
        }

        public IActionResult StudentEdit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Students.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StudentEdit(Student obj)
        {
            if (ModelState.IsValid) //Check data to will input
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("StudentIndex");
            }
            return View(obj);

        }

    }
}

