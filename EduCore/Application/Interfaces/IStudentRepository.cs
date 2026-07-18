using EduCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Application.Interfaces
{
    public interface IStudentRepository
    {
        Student Exist(string Email);
        bool AddStudent(Student student);
        bool UpdateStudent(Student student,string Email);
        bool DeleteStudent(int id);
        Student? GetById(int id);
        List<Student> GetAll(int page, int pageSize);
        List<Student> SearchByName(string name);
    }
}
