using EduCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Seed
{
    public static class StudentSeed
    {
        public static List<Student> GetStudentData()
        {
            return new List<Student>()
         {
            new Student { Id = 1, FullName = "Youssef Gamal", Email = "youssef.g@example.com", Phone = "01012345671", BirthDate = new DateTime(2000, 5, 10), RegisterDate = new DateTime(2023, 1, 5) },
            new Student { Id = 2, FullName = "Aya Mahmoud", Email = "aya.m@example.com", Phone = "01123456782", BirthDate = new DateTime(2001, 8, 20), RegisterDate = new DateTime(2023, 2, 10) },
            new Student { Id = 3, FullName = "Mahmoud Salah", Email = "mahmoud.s@example.com", Phone = "01234567893", BirthDate = new DateTime(1999, 12, 1), RegisterDate = new DateTime(2022, 11, 15) },
            new Student { Id = 4, FullName = "Fatma Said", Email = "fatma.s@example.com", Phone = "01545678904", BirthDate = new DateTime(2002, 3, 22), RegisterDate = new DateTime(2023, 5, 20) },
            new Student { Id = 5, FullName = "Karim Hassan", Email = "karim.h@example.com", Phone = "01056789015", BirthDate = new DateTime(1998, 7, 14), RegisterDate = new DateTime(2021, 9, 1) },
            new Student { Id = 6, FullName = "Nada Tarek", Email = "nada.t@example.com", Phone = "01167890126", BirthDate = new DateTime(2003, 1, 30), RegisterDate = new DateTime(2023, 8, 12) },
            new Student { Id = 7, FullName = "Amr Zaki", Email = "amr.z@example.com", Phone = "01278901237", BirthDate = new DateTime(2000, 11, 5), RegisterDate = new DateTime(2022, 12, 5) },
            new Student { Id = 8, FullName = "Hoda Ali", Email = "hoda.a@example.com", Phone = "01589012348", BirthDate = new DateTime(2001, 4, 18), RegisterDate = new DateTime(2023, 3, 25) },
            new Student { Id = 9, FullName = "Mostafa Kamal", Email = "mostafa.k@example.com", Phone = "01090123459", BirthDate = new DateTime(1997, 6, 9), RegisterDate = new DateTime(2020, 10, 10) },
            new Student { Id = 10, FullName = "Rana Othman", Email = "rana.o@example.com", Phone = "01101234560", BirthDate = new DateTime(2002, 9, 12), RegisterDate = new DateTime(2023, 7, 30) },
            new Student { Id = 11, FullName = "Omar Fathy", Email = "omar.f@example.com", Phone = "01212345671", BirthDate = new DateTime(1999, 2, 14), RegisterDate = new DateTime(2022, 1, 20) },
            new Student { Id = 12, FullName = "Salma Adel", Email = "salma.a@example.com", Phone = "01523456782", BirthDate = new DateTime(2001, 10, 5), RegisterDate = new DateTime(2023, 4, 15) },
            new Student { Id = 13, FullName = "Ahmed Mostafa", Email = "ahmed.m@example.com", Phone = "01034567893", BirthDate = new DateTime(1998, 11, 30), RegisterDate = new DateTime(2021, 6, 10) },
            new Student { Id = 14, FullName = "Mona Ibrahim", Email = "mona.i@example.com", Phone = "01145678904", BirthDate = new DateTime(2003, 5, 25), RegisterDate = new DateTime(2023, 9, 5) },
            new Student { Id = 15, FullName = "Tarek Khaled", Email = "tarek.k@example.com", Phone = "01256789015", BirthDate = new DateTime(2000, 8, 8), RegisterDate = new DateTime(2022, 3, 12) },
            new Student { Id = 16, FullName = "Dina Youssef", Email = "dina.y@example.com", Phone = "01567890126", BirthDate = new DateTime(1999, 4, 17), RegisterDate = new DateTime(2021, 11, 22) },
            new Student { Id = 17, FullName = "Hassan Wael", Email = "hassan.w@example.com", Phone = "01078901237", BirthDate = new DateTime(2002, 12, 3), RegisterDate = new DateTime(2023, 10, 1) },
            new Student { Id = 18, FullName = "Nour Farouk", Email = "nour.f@example.com", Phone = "01189012348", BirthDate = new DateTime(2001, 7, 21), RegisterDate = new DateTime(2022, 5, 18) },
            new Student { Id = 19, FullName = "Ziad Ziad", Email = "ziad.z@example.com", Phone = "01290123459", BirthDate = new DateTime(1998, 1, 15), RegisterDate = new DateTime(2020, 8, 30) },
            new Student { Id = 20, FullName = "Yasmine Samy", Email = "yasmine.s@example.com", Phone = "01501234560", BirthDate = new DateTime(2000, 6, 29), RegisterDate = new DateTime(2023, 2, 28) },
            new Student { Id = 21, FullName = "Ibrahim Gamal", Email = "ibrahim.g@example.com", Phone = "01011122233", BirthDate = new DateTime(1999, 9, 9), RegisterDate = new DateTime(2022, 7, 14) },
            new Student { Id = 22, FullName = "Laila Mahmoud", Email = "laila.m@example.com", Phone = "01122233344", BirthDate = new DateTime(2003, 2, 11), RegisterDate = new DateTime(2023, 11, 5) },
            new Student { Id = 23, FullName = "Kareem Salah", Email = "kareem.s@example.com", Phone = "01233344455", BirthDate = new DateTime(1997, 10, 22), RegisterDate = new DateTime(2020, 1, 10) },
            new Student { Id = 24, FullName = "Sara Said", Email = "sara.s@example.com", Phone = "01544455566", BirthDate = new DateTime(2001, 3, 14), RegisterDate = new DateTime(2022, 9, 25) },
            new Student { Id = 25, FullName = "Ali Hassan", Email = "ali.h@example.com", Phone = "01055566677", BirthDate = new DateTime(1998, 8, 5), RegisterDate = new DateTime(2021, 4, 12) },
            new Student { Id = 26, FullName = "Habiba Tarek", Email = "habiba.t@example.com", Phone = "01166677788", BirthDate = new DateTime(2002, 1, 27), RegisterDate = new DateTime(2023, 6, 20) },
            new Student { Id = 27, FullName = "Wael Zaki", Email = "wael.z@example.com", Phone = "01277788899", BirthDate = new DateTime(2000, 5, 30), RegisterDate = new DateTime(2022, 10, 8) },
            new Student { Id = 28, FullName = "Farah Ali", Email = "farah.a@example.com", Phone = "01588899900", BirthDate = new DateTime(1999, 11, 18), RegisterDate = new DateTime(2021, 2, 15) },
            new Student { Id = 29, FullName = "Saad Kamal", Email = "saad.k@example.com", Phone = "01099900011", BirthDate = new DateTime(2001, 7, 7), RegisterDate = new DateTime(2023, 3, 30) },
            new Student { Id = 30, FullName = "Malak Othman", Email = "malak.o@example.com", Phone = "01100011122", BirthDate = new DateTime(2003, 4, 2), RegisterDate = new DateTime(2023, 12, 1) }
          };
        }
    }
}
