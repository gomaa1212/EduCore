using EduCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Seed
{
    public static class DepartmentSeed
    {
        public static List<Department> GetDepartmentData()
        {
            return new List<Department>()
            {
                 new Department { Id = 1, Name = "Computer Science", Description = "Software Development & Programming" },
                 new Department { Id = 2, Name = "Artificial Intelligence", Description = "AI & Machine Learning" },
                 new Department { Id = 3, Name = "Cyber Security", Description = "Security & Networking" },
                 new Department { Id = 4, Name = "Business", Description = "Business Administration" },
                 new Department { Id = 5, Name = "Design", Description = "UI/UX & Graphic Design" },
                 new Department { Id = 6, Name = "Data Science", Description = "Data Analysis and Big Data" },
                 new Department { Id = 7, Name = "Languages", Description = "English, Spanish, and German" }
            };
        }
    }
}
