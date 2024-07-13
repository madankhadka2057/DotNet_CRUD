using DotNetDay3.Models;

namespace DotNetDay3.SolidPrinciple
{
    public class StudentRepository:IStudentRepository
    {
        public List<Student> StudentList()
        {
            List<Student> std = new()
            {
                new Student {Id=1,Name="Madan",Address="Pyuthan" },
                new Student {Id=2,Name="Hari",Address="Gulmi" },
                new Student {Id=3,Name="Badri",Address="Pyuthan" },
            };
            return std;
        }
        public IEnumerable<Student> GetList()
        {
            return StudentList();
        }
        public Student GetStudentById(int id)
        {
            return StudentList().Where(x=>x.Id==id).First();
        }
        public void AddStudent(Student std)
        {

        }
        public void UpdateStudent(Student std)
        {

        }
        public void DeleteStudent(int id)
        {

        }

    }
}
