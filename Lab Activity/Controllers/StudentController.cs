using Microsoft.AspNetCore.Mvc;
using Lab_Activity.Models;

namespace Lab_Activity.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Killua",LastName = "Zoldy", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-06-22"), GPA = 1.3, Email = "kill22@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Jhin",LastName = "Dela Monte", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-09-01"), GPA = 1.1, Email = "Jhin0901@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Dodie",LastName = "Dorotea", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2021-02-23"), GPA = 1.2, Email = "Dodie023@gmail.com"
                }
            };
        public IActionResult Index()
        {
            
            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

    }
}