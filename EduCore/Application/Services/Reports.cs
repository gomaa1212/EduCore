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
        public static void Report1()
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
        public static void Report3()
        {
            using (var db = new AppDbContext())
            {
                var res = db.Departments.Select(x => new
                {
                    DeptName = x.Name,
                    CoursesCount = x.Courses.Count,
                    InstructorsCount = x.Instructors.Count,
                    StudentsCount = x.Courses.SelectMany(x => x.Enrollments).Distinct().Count()
                });
                Console.WriteLine($"{"Department Name",-25} {"Courses",-15} {"Instructors",-15} {"Students",-15}");

                Console.WriteLine(new string('-', 70));

                foreach (var d in res)
                {
                    Console.WriteLine($"{d.DeptName,-25} {d.CoursesCount,-15} {d.InstructorsCount,-15} {d.StudentsCount,-15}");
                }
            }
        }
        public static void Report4()
        {
            using (var db = new AppDbContext())
            {
                var res = db.Courses.Select(x => new
                {
                    CourseName = x.Title,
                    NumberOfStudents = x.Enrollments.Count
                }).OrderByDescending(x=>x.NumberOfStudents).Take(5);
                Console.WriteLine($"{"Course Name",-40} {"Students Count",-15}");
                Console.WriteLine(new string('-', 55));

                foreach (var c in res)
                {
                    Console.WriteLine($"{c.CourseName,-40} {c.NumberOfStudents,-15}");
                }
            }
        }
        public static void Report5()
        {
            using (var db = new AppDbContext())
            {
                Console.WriteLine("Students that don't have courses : \n");
                var res = db.Students.Where(x => !x.Enrollments.Any()).ToList();
                if (!res.Any())
                {
                    Console.WriteLine("All Students have course");
                }
                else
                {
                    foreach (var d in res)
                    {
                        Console.WriteLine(d);
                    }
                }
            }
        }
        public static void Report6()
        {
            using (var db = new AppDbContext())
            {
                Console.WriteLine("Courses that don't have students : \n");
                var res = db.Courses.Where(x=>!x.Enrollments.Any()).ToList();
                if(!res.Any())
                {
                    Console.WriteLine("All Courses Have Students");
                }
                else
                {
                    foreach (var r in res)
                    {
                        Console.WriteLine(r);
                    }
                }
            }
        }
        public static void Report7()
        {
            using (var db = new AppDbContext())
            {
                var res = db.Departments.Select(x => new
                {
                    DepartmentName = x.Name,
                    AveragePrice = x.Courses.Average(x => x.Price)
                }).OrderByDescending(x=>x.AveragePrice).ToList();
                Console.WriteLine($"{"Department Name",-25} {"Average Price",-15}");
                Console.WriteLine(new string('-', 40));

                foreach (var d in res)
                {
                    Console.WriteLine($"{d.DepartmentName,-25} {d.AveragePrice,-15:C}");
                }
            }
        }
        public static void Dashboard()
        {
            using (var db = new AppDbContext())
            {
                var NumOfStudents = db.Students.Count();
                var NumOfCourses = db.Courses.Count();
                var NumOfDepartments = db.Departments.Count();
                var NumOfInstructors = db.Instructors.Count();
                var NumOfEnrollments = db.Enrollments.Count();

                var MostPopularCourse = db.Courses.OrderByDescending(x => x.Enrollments.Count())
                                                   .Select(x => x.Title)
                                                   .FirstOrDefault() ?? "N/A";

                var LargestDepartment = db.Departments.OrderByDescending(x => x.Courses.Count())
                                                       .Select(x => x.Name)
                                                       .FirstOrDefault() ?? "N/A";

                var AverageCoursePrice = db.Courses.Average(x => (decimal?)x.Price) ?? 0;

                Console.WriteLine($"{"=== SYSTEM DASHBOARD ===",-40}");
                Console.WriteLine(new string('-', 45));

                Console.WriteLine($"{"Total Students",-25} : {NumOfStudents}");
                Console.WriteLine($"{"Total Courses",-25} : {NumOfCourses}");
                Console.WriteLine($"{"Total Departments",-25} : {NumOfDepartments}");
                Console.WriteLine($"{"Total Instructors",-25} : {NumOfInstructors}");
                Console.WriteLine($"{"Total Enrollments",-25} : {NumOfEnrollments}");

                Console.WriteLine(new string('-', 45));

                Console.WriteLine($"{"Most Popular Course",-25} : {MostPopularCourse}");
                Console.WriteLine($"{"Largest Department",-25} : {LargestDepartment}");
                Console.WriteLine($"{"Average Course Price",-25} : {AverageCoursePrice:C}");

                Console.WriteLine(new string('-', 45));

            }
        }
        public static void ExecuteReports()
        {
            Report1();
            Console.WriteLine();
            Report2();
            Console.WriteLine();
            Report3();
            Console.WriteLine();
            Report4();
            Console.WriteLine();
            Report5();
            Console.WriteLine();
            Report6();
            Console.WriteLine();
            Report7();
            Console.WriteLine();
            Dashboard();
            Console.WriteLine();
        }


    }
}
