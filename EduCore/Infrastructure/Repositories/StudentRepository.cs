using EduCore.Domain.Entities;
using EduCore.Infrastructure.Data;
using EduCore.Infrastructure.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Repositories
{

    public static class StudentRepository
    {
        public static Student Exist(string Eamil)
        {
            
            using (var db = new AppDbContext())
            {
                var student = db.Students.FirstOrDefault(s=>s.Email == Eamil);
                return student;

            }

        }
        public static bool AddStudent(Student student)
        {
            using (var db = new AppDbContext())
            {
                if (db.Students.Any(s=>s.Email==student.Email))
                {
                    return false;
                }
                db.Students.Add(student);
                db.SaveChanges();
                return true;
            }
        }
        public static bool UpdateStudent(Student student,string Email)
        {
            using (var db = new AppDbContext())
            {
                var exist = db.Students.FirstOrDefault(s => s.Email == Email);
                if (exist == null)
                {
                    return false;
                }
                exist.FullName = student.FullName;
                exist.Email = student.Email;
                exist.Phone = student.Phone;
                exist.BirthDate = student.BirthDate;
                exist.RegisterDate = student.RegisterDate;
                db.SaveChanges();
                return true;
            }
        }
        public static bool DeleteStudent(int id)
        {
            var db=new AppDbContext();
            var student = db.Students.Find(id);
            if(student is null)
            {
                return false;
            }
            db.Students.Remove(student);
            db.SaveChanges();
            return true;
        }
        public static Student GetById(int id)
        {
            var db = new AppDbContext();
            var student=db.Students.Find(id);
            return student;
        }
        public static List<Student> GetAll()
        {
            var db=new AppDbContext();
            var students=db.Students.ToList();
            return students;
        }
        public static List<Student> SearchByName(string name)
        {
            var db = new AppDbContext();
            var students= db.Students.Where(x=>x.FullName.ToUpper().Contains(name.ToUpper())).ToList();
            return students;
        }
    } 
}
