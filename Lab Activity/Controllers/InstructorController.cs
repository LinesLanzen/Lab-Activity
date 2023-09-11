using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Lab_Activity.Models;

namespace Lab_Activity.Controllers
{
    public class InstructorController : Controller
    {
        // Sample instructor data (you should replace this with your data source)
        private static List<Instructor> instructors = new List<Instructor>
        {
            new Instructor()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Torres",
                IsTenured = false,
                Rank = "Intern",
                HiringDate = new DateTime(2022,2, 15)
             },

             new Instructor()
            {
                Id = 2,
                FirstName = "Moon",
                LastName = "Dela Cruz",
                IsTenured = true,
                Rank = "Professor",
                HiringDate = new DateTime(2010, 12,12)
             },

              new Instructor()
    {
                Id = 3,
                FirstName = "Perla",
                LastName = "Fernando",
                IsTenured = true,
                Rank = "Professor",
                HiringDate = new DateTime(1980,2,11)
              }
        };

        // GET: Instructor
        public ActionResult Index()
        {
            return View(instructors);
        }

        public ActionResult ShowDetails(int id)
        {
            Instructor? instructor = instructors.FirstOrDefault(i => i.Id == id);
            if (instructor == null)
            {
                ViewBag.ErrorMessage = "Instructor not found.";
                return View("CustomErrorView");
            }
            return View(instructor);
        }
    }
}