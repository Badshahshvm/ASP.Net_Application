using Microsoft.AspNetCore.Mvc;
using Scaffoulding.Models;

namespace Scaffoulding.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
            {
                new Student()
                {
                    name="Shivam",
                    roll=21,
                    gender="Male",
                    email="badshahShvm@gmail.com",
                    course="Java"
                },
                 new Student()
                {
                    name="Shivani",
                    roll=21,
                    gender="Female",
                    email="Shiu@gmail.com",
                    course="C++"
                },
                   new Student()
                {
                    name="Surya",
                    roll=23,
                    gender="Male",
                    email="Surya@gmail.com",
                    course="Machine Learning"
                }

            };
        public IActionResult Index()
        {
           
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            Student student = students.FirstOrDefault(x=>x.roll==id);
            return View(student);
        }
        public IActionResult Details(int id)
        {
            Student student = students.FirstOrDefault(x => x.roll == id);
            return View(student);
            return View();
        }
        public IActionResult Delete(int id)
        {
            Student student = students.FirstOrDefault(x => x.roll == id);
            return View(student);
            return View();
        }
    }
}
