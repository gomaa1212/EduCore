using EduCore.Application.Interfaces;
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

    public  class StudentRepository : IStudentRepository
    {
        public  Student Exist(string Eamil)
        {
            
            using (var db = new AppDbContext())
            {
                var student = db.Students.FirstOrDefault(s=>s.Email == Eamil);
                return student;

            }

        }
        public  bool AddStudent(Student student)
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
        public  bool UpdateStudent(Student student,string Email)
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
        public  bool DeleteStudent(int id)
        {
            using (var db = new AppDbContext())
            {
                var student = db.Students.Find(id);
                if (student is null)
                {
                    return false;
                }
                db.Students.Remove(student);
                db.SaveChanges();
                return true;
            }
        }
        public  Student GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                var student = db.Students.Find(id);
                return student;
            }
        }
        public  List<Student> GetAll(int page , int pageSize)
        {
            using (var db = new AppDbContext())
            {
                if (pageSize<1)
                {
                    return new List<Student>();
                }
                var students = db.Students.OrderBy(x=>x.Id).Skip(pageSize*(page-1)).Take(pageSize).ToList();
                return students;
            }
        }
        public  List<Student> SearchByName(string name)
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students.Where(x => x.FullName.ToUpper().Contains(name.ToUpper())).ToList();
                return students;
            }
        }
    } 
}
