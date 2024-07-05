using Microsoft.AspNetCore.Mvc;
using CRUD_APP.Models;
using CRUD_APP.Data;
using CRUD_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace CRUD_APP.Controllers
{
    public class StudentController: Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //Show Add Student from!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //Add Student into database!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        [HttpPost]
        public async Task<IActionResult>Add(AddStudentViewModel viewModel)
        {
            //return json(viewmodel);
            var std = new Student()
            {
                Name = viewModel.Name,
                Email=viewModel.Email,
                roll = viewModel.roll
            };
            await dbContext.AddAsync(std);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "Student");
            //return View(newViewModel);
        }
        //Show Stuednt records!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        [HttpGet]
        public  IActionResult List()
        {
            var std=  dbContext.Students.ToList();
            //return Json(data);
            return View(std);
        }
        //Delete Student record form database!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student=await dbContext.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x=>x.Id==viewModel.Id);
            if (student != null) {
                dbContext.Students.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            return RedirectToAction("List","Student");
            }
            else
            {
                return Json(new { success = false, message = "Student not found with that id" });
            }
        }
        // Show Edit Student record page also send data to input field!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var Data= await dbContext.Students.FindAsync(id);
            return View(Data);
        }
        //Edit Student record!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student=await dbContext.Students.FindAsync(viewModel.Id);
            if (student is not null) {
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                student.roll=viewModel.roll;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");
        }
    }
}

