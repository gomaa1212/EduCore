using EduCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Application.Services
{
    public static class Reports
    {
        public static void NumberOfCoursesForStudents()
        {
            using (var db = new AppDbContext())
            {
               var res = db.Students.Select(x => new
                                      {
                                          Name = x.FullName
                                         ,Email = x.Email
                                         ,Count =  x.Enrollments.Count 
                                      }).ToList();
                Console.WriteLine($"{"Name",-20} {"Email",-30} {"Num Of Courses",-10}");
                Console.WriteLine(new string('-', 60)); 

                foreach (var s in res)
                {
                    Console.WriteLine($"{s.Name,-20} {s.Email,-30} {s.Count,-20}");
                }
            }
        }
        public static void Report2()
        {
            using (var db = new AppDbContext())
            {
                var res = db.Courses.Select(x => new
                {
                    CourseName = x.Title,
                    DepartmentName = x.Department.Name,
                    InstructorName = x.Instructor.FullName,
                    NUmلاberOfStudents = x.Enrollments.Count
                }).ToList().OrderByDescending(x=>x.NUmلاberOfStudents);
                Console.WriteLine($"{"Course Name",-30} {"Department",-25} {"Instructor",-25} {"Students Count",-15}");

                Console.WriteLine(new string('-', 95));

                foreach (var c in res)
                {
                    Console.WriteLine($"{c.CourseName,-30} {c.DepartmentName,-25} {c.InstructorName,-25} {c.NUmلاberOfStudents,-15}");
                }
            }
        }
    }
}
