using EduCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Seed
{
    public static class CourseSeed
    {
        public static List<Course> GetCourseData()
        {
            return new List<Course>()
          {
            new Course { Id = 1, Title = "C# Basics", Description = "Learn C# from scratch", Hours = 40, Price = 1500.00m, DepartmentId = 1, InstructorId = 1 },
            new Course { Id = 2, Title = "ASP.NET Core", Description = "Build web apps", Hours = 60, Price = 2500.00m, DepartmentId = 1, InstructorId = 2 },
            new Course { Id = 3, Title = "Machine Learning", Description = "Intro to ML", Hours = 50, Price = 3000.00m, DepartmentId = 2, InstructorId = 3 },
            new Course { Id = 4, Title = "Deep Learning", Description = "Neural networks", Hours = 70, Price = 3500.00m, DepartmentId = 2, InstructorId = 4 },
            new Course { Id = 5, Title = "Ethical Hacking", Description = "Penetration testing", Hours = 45, Price = 2800.00m, DepartmentId = 3, InstructorId = 5 },
            new Course { Id = 6, Title = "Network Security", Description = "Securing networks", Hours = 55, Price = 2600.00m, DepartmentId = 3, InstructorId = 13 },
            new Course { Id = 7, Title = "Marketing 101", Description = "Marketing principles", Hours = 30, Price = 1000.00m, DepartmentId = 4, InstructorId = 6 },
            new Course { Id = 8, Title = "Project Management", Description = "PMP basics", Hours = 40, Price = 1800.00m, DepartmentId = 4, InstructorId = 7 },
            new Course { Id = 9, Title = "UI/UX Fundamentals", Description = "Design interfaces", Hours = 35, Price = 1200.00m, DepartmentId = 5, InstructorId = 8 },
            new Course { Id = 10, Title = "Python for Data Science", Description = "Pandas & NumPy", Hours = 50, Price = 2200.00m, DepartmentId = 6, InstructorId = 9 },
            new Course { Id = 11, Title = "English B2", Description = "Intermediate conversation", Hours = 40, Price = 800.00m, DepartmentId = 7, InstructorId = 10 },
            new Course { Id = 12, Title = "Data Structures", Description = "Algorithms in C#", Hours = 45, Price = 1700.00m, DepartmentId = 1, InstructorId = 11 },
            new Course { Id = 13, Title = "Computer Vision", Description = "Image processing", Hours = 60, Price = 3200.00m, DepartmentId = 2, InstructorId = 12 },
            new Course { Id = 14, Title = "Cryptography", Description = "Encryption techniques", Hours = 50, Price = 2900.00m, DepartmentId = 3, InstructorId = 5 },
            new Course { Id = 15, Title = "Graphic Design", Description = "Photoshop & Illustrator", Hours = 40, Price = 1400.00m, DepartmentId = 5, InstructorId = 14 },
            new Course { Id = 16, Title = "Big Data", Description = "Hadoop & Spark", Hours = 65, Price = 3100.00m, DepartmentId = 6, InstructorId = 15 },
            new Course { Id = 17, Title = "Spanish A1", Description = "Beginner Spanish", Hours = 30, Price = 700.00m, DepartmentId = 7, InstructorId = 10 },
            new Course { Id = 18, Title = "HR Management", Description = "Human resources basics", Hours = 35, Price = 1100.00m, DepartmentId = 4, InstructorId = 6 },
            new Course { Id = 19, Title = "Web Design", Description = "HTML, CSS, JS", Hours = 45, Price = 1300.00m, DepartmentId = 5, InstructorId = 8 },
            new Course { Id = 20, Title = "Cloud Computing", Description = "AWS & Azure", Hours = 55, Price = 2700.00m, DepartmentId = 1, InstructorId = 2 }
         };
        }
    }
}
