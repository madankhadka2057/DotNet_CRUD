using DotNetDay3.Models;

namespace DotNetDay3.SolidPrinciple
{
    public interface IStudentService
    {
        public List<StudentDb>  GetStudents();

        public StudentDb GetStudentById(int id);
        public void AddStd(StudentDb std);
        public void UpdateStd(StudentDb std);
        public void DeleteStd(StudentDb id);

    }
}
