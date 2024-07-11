using DotNetDay3.Models;

namespace DotNetDay3.SolidPrinciple
{
    public interface IStudentService
    {
        IEnumerable<Student>  getStudents();

        Student getStudentById(int id);
        void AddStd(Student std);
        void UpdateStd(Student std);
        void DeleteStd(Student id);

    }
}
