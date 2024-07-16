using DotNetDay3.Models;
using DotNetDay3.Security;
using DotNetDay3.SolidPrinciple;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDay3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _service;
        private readonly IDataProtector _dataProtector;
        private readonly IWebHostEnvironment _env;
        public HomeController(IStudentService services, DataSecurityProvider secProvide, IDataProtectionProvider provider,IWebHostEnvironment env)
        {
            _service = services;
            _dataProtector = provider.CreateProtector(secProvide.ProtectKey);
            _env = env;
        }
        public IActionResult Index()
        {
            var StudentData = _service.GetStudents();
            var std = StudentData.Select(data =>
            {
                return new StudentEdit
                {
                    Id = data.Id,
                    Name = data.Name,
                    Phone = data.Phone,
                    Email = data.Email,
                    Password = data.Password,
                    Status = data.Status,
                    UserRole = data.UserRole
                };
            }).ToList();

            //return Json(std);
            return View(std);
        }
        [HttpGet]
        public IActionResult Detail(int Id)
        {
            //Conveting string Encrypted(Protect) id to Integer ,like id="djfdfdbfnskfhkjfsdf" --> id=djfdfdbfnskfhkjfsdf
            //And also Decrypt(Unprotect) the id ,like id= djfdfdbfnskfhkjfsdf to id=1(actual id of user )
            StudentDb std = _service.GetStudentById(Id);
            return Json(std);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentEdit stdData)
        {

            if (stdData != null)
            {
                string fileName= Guid.NewGuid().ToString()+"_"+stdData.FileUpload.FileName.ToString();
                string filePath = Path.Combine(_env.WebRootPath, "Uploads", fileName);
                using(FileStream str=new FileStream(filePath, FileMode.Create))
                {
                    stdData.FileUpload.CopyTo(str);
                }
                stdData.FileUpload = filePath;
                return Json(new { fileName = fileName, filePath = filePath });

            }
            return View(stdData);
        }
    }
}
