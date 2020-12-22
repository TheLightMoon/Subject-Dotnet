using LabOfTask05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabOfTask05.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            ViewBag.Message = "Student description page.";
            Student std = new Student();
            std.FamilyName = "Nguyen"; std.MiddleName = "Viet"; std.Name = "Ha";
            //std.BirthDate = DateTime.Parse();
            //std.GetCurrentAge = 23;
            std.YourEmail = "nguyenviethoangbm9x@gmail.com";
            std.PhoneNumber = 0502909569;
            std.Faculty = "Computer and Information Technologies";
            //std.Admission = 2018;
            //std.GetCourseNo = 3;
            //std.GetSemesterNo = 4;
            return View(std);
        }

        public ActionResult Games()
        {
            ViewBag.Message = "Your Game page.";

            return View();
        }
    }
}