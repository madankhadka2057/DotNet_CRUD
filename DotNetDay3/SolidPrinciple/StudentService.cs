using DotNetDay3.Models;

namespace DotNetDay3.SolidPrinciple
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<StudentDb> GetStudents() => _repo.GetList();

        public StudentDb GetStudentById(int id)
        { 
            return _repo.GetStudentById(id);
        }
        public void AddStd(StudentDb std)
        {
        }
        public void UpdateStd(StudentDb std) { }
        public void DeleteStd(StudentDb id) { }

    }
}
