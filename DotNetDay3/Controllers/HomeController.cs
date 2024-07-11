using DotNetDay3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDay3.Controllers
{
    public class HomeController : Controller
    {
        public List<Student> GetStudent()
        {
            List<Student> std = new List<Student>()
            {
                new Student{Id=1,Name="Madan",Address="Pyuthan"},
                new Student{Id=2,Name="Badri",Address="Pyuthan"},
                new Student{Id=4,Name="Hari",Address="Gulmi"},
                new Student{Id=5,Name="Anita",Address="Butwal"},
                new Student{Id=9,Name="Resham",Address="Rupandehi"},
                new Student{Id=6,Name="Nabin",Address="Butwal"},
                new Student{Id=8,Name="Durga",Address="Pyuthan"},

            };
            return std;
        }
        public IActionResult Index()
        {
            List < Student > StudentData= GetStudent();
            //return Json(StudentData);
            return View(StudentData);
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            List<Student> StudentData = GetStudent();
            var std= StudentData.Where(x=>x.Id==id).First();
            return Json(std);
        }
    }
}
