using DotNetDay3.Models;
namespace DotNetDay3.SolidPrinciple
{
    public class StudentRepository:IStudentRepository
    {
        private readonly StudentContext _context;
        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public List<StudentDb> GetList()
        {
            var students = _context.StudentDbs.ToList();
            return students ;
        }
        public StudentDb GetStudentById(int id)
        {
              
            StudentDb data= _context.StudentDbs.Where(x=>x.Id==id).First();
              return data;
        }
        public void AddStudent(StudentDb std)
        {

        }
        public void UpdateStudent(StudentDb std)
        {

        }
        public void DeleteStudent(int id)
        {

        }

    }
}
