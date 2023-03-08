using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FristApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FristApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Student s1 = new();
            s1.Id = 00001;
            s1.Name = "ประชา มาดี";
            s1.Score = 100;

            var s2 = new Student();
            s2.Id = 00002;
            s2.Name = "พงษ์ดี ดำได้";
            s2.Score = 80;

            Student s3 = new();
            s3.Id = 00003;
            s3.Name = "อนุรักษ์ รักษา";
            s3.Score = 49;

            List<Student> allStudent = new List<Student>();
            allStudent.Add(s1);
            allStudent.Add(s2);
            allStudent.Add(s3);

            return View(allStudent);

        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}

