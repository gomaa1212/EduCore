using EduCore.Domain.Entities;
using EduCore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Seed
{
    public static class EnrollmentSeed
    {
        public static List<Enrollment> GetEnrollmentData()
        {
            return new List<Enrollment>()
          {  
            new Enrollment { StudentId = 1, CourseId = 1, EnrollDate = new DateTime(2023, 1, 10), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 1, CourseId = 2, EnrollDate = new DateTime(2023, 3, 15), Progress = 40, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 2, CourseId = 3, EnrollDate = new DateTime(2023, 2, 20), Progress = 80, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 2, CourseId = 4, EnrollDate = new DateTime(2023, 6, 1), Progress = 0, Status = EnrollmentStatus.Pending },
            new Enrollment { StudentId = 3, CourseId = 5, EnrollDate = new DateTime(2022, 11, 20), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 4, CourseId = 1, EnrollDate = new DateTime(2023, 5, 25), Progress = 50, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 4, CourseId = 9, EnrollDate = new DateTime(2023, 6, 10), Progress = 10, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 5, CourseId = 8, EnrollDate = new DateTime(2021, 9, 10), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 5, CourseId = 7, EnrollDate = new DateTime(2021, 10, 5), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 6, CourseId = 11, EnrollDate = new DateTime(2023, 8, 15), Progress = 5, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 7, CourseId = 10, EnrollDate = new DateTime(2022, 12, 10), Progress = 90, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 8, CourseId = 2, EnrollDate = new DateTime(2023, 4, 1), Progress = 30, Status = EnrollmentStatus.Cancelled },
            new Enrollment { StudentId = 9, CourseId = 5, EnrollDate = new DateTime(2020, 10, 15), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 9, CourseId = 6, EnrollDate = new DateTime(2021, 1, 10), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 10, CourseId = 12, EnrollDate = new DateTime(2023, 8, 5), Progress = 20, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 11, CourseId = 13, EnrollDate = new DateTime(2023, 1, 5), Progress = 60, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 12, CourseId = 14, EnrollDate = new DateTime(2023, 2, 11), Progress = 45, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 13, CourseId = 15, EnrollDate = new DateTime(2023, 3, 22), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 14, CourseId = 16, EnrollDate = new DateTime(2023, 4, 18), Progress = 75, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 15, CourseId = 17, EnrollDate = new DateTime(2023, 5, 9), Progress = 10, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 16, CourseId = 18, EnrollDate = new DateTime(2022, 6, 30), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 17, CourseId = 19, EnrollDate = new DateTime(2023, 7, 12), Progress = 35, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 18, CourseId = 20, EnrollDate = new DateTime(2023, 8, 25), Progress = 55, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 19, CourseId = 1, EnrollDate = new DateTime(2023, 9, 14), Progress = 0, Status = EnrollmentStatus.Pending },
            new Enrollment { StudentId = 20, CourseId = 2, EnrollDate = new DateTime(2023, 10, 5), Progress = 0, Status = EnrollmentStatus.Pending },
            new Enrollment { StudentId = 21, CourseId = 3, EnrollDate = new DateTime(2022, 1, 20), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 22, CourseId = 4, EnrollDate = new DateTime(2023, 2, 17), Progress = 85, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 23, CourseId = 5, EnrollDate = new DateTime(2023, 3, 8), Progress = 40, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 24, CourseId = 6, EnrollDate = new DateTime(2023, 4, 29), Progress = 25, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 25, CourseId = 7, EnrollDate = new DateTime(2022, 5, 15), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 26, CourseId = 8, EnrollDate = new DateTime(2023, 6, 22), Progress = 50, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 27, CourseId = 9, EnrollDate = new DateTime(2023, 7, 11), Progress = 15, Status = EnrollmentStatus.Active },
            new Enrollment { StudentId = 28, CourseId = 10, EnrollDate = new DateTime(2022, 8, 5), Progress = 100, Status = EnrollmentStatus.Completed },
            new Enrollment { StudentId = 29, CourseId = 11, EnrollDate = new DateTime(2023, 9, 1), Progress = 0, Status = EnrollmentStatus.Cancelled },
            new Enrollment { StudentId = 30, CourseId = 12, EnrollDate = new DateTime(2023, 10, 10), Progress = 5, Status = EnrollmentStatus.Active }
          };
        }
    }
    
}
