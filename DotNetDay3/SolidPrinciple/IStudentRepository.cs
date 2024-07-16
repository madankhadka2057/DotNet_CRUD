using DotNetDay3.Models;
using System.Collections.Generic;

namespace DotNetDay3.SolidPrinciple
{
    public interface IStudentRepository
    {
       public List<StudentDb>GetList();
       public StudentDb GetStudentById(int id);
       public void AddStudent(StudentDb std);
       public void UpdateStudent(StudentDb std);
       public void DeleteStudent(int id);

    }
}
