using EduCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Seed
{
    public static class InstructorSeed
    {
        public static List<Instructor> GetInstructorData()
        {
            return new List<Instructor>()
         {
            new Instructor { Id = 1, FullName = "Ahmed Ali", Email = "ahmed.ali@univ.edu", Phone = "01011110001", Salary = 12000.00m, HireDate = new DateTime(2015, 8, 1), DepartmentId = 1 },
            new Instructor { Id = 2, FullName = "Sara Hassan", Email = "sara.hassan@univ.edu", Phone = "01122220002", Salary = 13500.50m, HireDate = new DateTime(2016, 9, 15), DepartmentId = 1 },
            new Instructor { Id = 3, FullName = "Mohamed Tarek", Email = "m.tarek@univ.edu", Phone = "01233330003", Salary = 15000.00m, HireDate = new DateTime(2018, 1, 10), DepartmentId = 2 },
            new Instructor { Id = 4, FullName = "Nour Youssef", Email = "nour.y@univ.edu", Phone = "01544440004", Salary = 14200.00m, HireDate = new DateTime(2019, 3, 20), DepartmentId = 2 },
            new Instructor { Id = 5, FullName = "Omar Khaled", Email = "omar.khaled@univ.edu", Phone = "01055550005", Salary = 16000.00m, HireDate = new DateTime(2014, 11, 5), DepartmentId = 3 },
            new Instructor { Id = 6, FullName = "Mona Ibrahim", Email = "mona.i@univ.edu", Phone = "01166660006", Salary = 11000.00m, HireDate = new DateTime(2020, 2, 28), DepartmentId = 4 },
            new Instructor { Id = 7, FullName = "Hany Said", Email = "hany.said@univ.edu", Phone = "01277770007", Salary = 11500.00m, HireDate = new DateTime(2021, 7, 1), DepartmentId = 4 },
            new Instructor { Id = 8, FullName = "Dina Adel", Email = "dina.adel@univ.edu", Phone = "01588880008", Salary = 12500.00m, HireDate = new DateTime(2017, 5, 12), DepartmentId = 5 },
            new Instructor { Id = 9, FullName = "Tarek Ziad", Email = "tarek.z@univ.edu", Phone = "01099990009", Salary = 14000.00m, HireDate = new DateTime(2016, 10, 30), DepartmentId = 6 },
            new Instructor { Id = 10, FullName = "Salma Farouk", Email = "salma.f@univ.edu", Phone = "01100000010", Salary = 9500.00m, HireDate = new DateTime(2022, 1, 15), DepartmentId = 7 },
            new Instructor { Id = 11, FullName = "Yassin Mahmoud", Email = "yassin.m@univ.edu", Phone = "01211110011", Salary = 13000.00m, HireDate = new DateTime(2019, 4, 10), DepartmentId = 1 },
            new Instructor { Id = 12, FullName = "Laila Kamal", Email = "laila.k@univ.edu", Phone = "01522220012", Salary = 17000.00m, HireDate = new DateTime(2013, 8, 20), DepartmentId = 2 },
            new Instructor { Id = 13, FullName = "Ibrahim Mostafa", Email = "ibrahim.m@univ.edu", Phone = "01033330013", Salary = 14500.00m, HireDate = new DateTime(2018, 6, 15), DepartmentId = 3 },
            new Instructor { Id = 14, FullName = "Yasmine Fathy", Email = "yasmine.f@univ.edu", Phone = "01144440014", Salary = 10500.00m, HireDate = new DateTime(2021, 2, 10), DepartmentId = 5 },
            new Instructor { Id = 15, FullName = "Kareem Wael", Email = "kareem.w@univ.edu", Phone = "01255550015", Salary = 15500.00m, HireDate = new DateTime(2015, 12, 1), DepartmentId = 6 }
         };
        }

    }
}
