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
        public HomeController(IStudentService services, DataSecurityProvider secProvide,IDataProtectionProvider provider)
        {
            _service = services;
            _dataProtector = provider.CreateProtector( secProvide.ProtectKey);
        }
        public IActionResult Index()
        {
            var StudentData=_service.getStudents();
            var std = StudentData.Select(data =>
            {
                return new Student
                {
                    Id = data.Id,
                    Name = data.Name,
                    Address = data.Address,
                    encId = _dataProtector.Protect(data.Id.ToString())//set data Id as encrypt form
                };
            }).ToList();

            return View(std);
        }
        [HttpGet]
        public IActionResult Detail(string id)
        {
           
            int userid = Convert.ToInt32(_dataProtector.Unprotect(id));
            Student std = _service.getStudentById(userid);
            return Json(std);
        }
    }
}
