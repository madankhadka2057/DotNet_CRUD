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

        public IEnumerable<Student> getStudents() => _repo.GetList();

        public Student getStudentById(int id)
        { 
            return _repo.GetStudentById(id);
        }
        public void AddStd(Student std)
        {
        }
        public void UpdateStd(Student std) { }
        public void DeleteStd(Student id) { }

    }
}
