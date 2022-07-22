using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        schoolEntities db = new schoolEntities();
        public ActionResult Index()
        {
            //ViewData["students"] = std;
            //ViewData["teachers"] = tchr;
            //ViewBag.students = std;
            //ViewBag.teachers = tchr;
            //MultiDataModel data = new MultiDataModel();
            //data.my_students = std;
            //data.my_teacher = tchr;

            return View();
        }

        public PartialViewResult Students()
        {
            var std = getStudents();
            return PartialView("_students",std);
        }

        public PartialViewResult Teachers()
        {
            var tchr = getTeachers();
            return PartialView("_teachers", tchr);
        }

        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
    }
}