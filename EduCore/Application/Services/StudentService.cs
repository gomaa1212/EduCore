using EduCore.Domain.Entities;
using EduCore.Infrastructure.Repositories;
using EduCore.View.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Application.Services
{
    public static class StudentService
    {
        public static void studentService()
        {
            var student = new Student();
            int choice = StudentMenu.studentMenu();
            switch(choice)
            {
                case 1:
                    Console.WriteLine("For adding new student please fill this fields.");
                    Console.Write("Full Name : ");
                    student.FullName = Console.ReadLine();
                    Console.Write("Email : ");
                    student.Email = Console.ReadLine();
                    Console.Write("Phone : ");
                    student.Phone = Console.ReadLine();
                    Console.Write("Birth Date (e.g., 25/05/2000): ");
                    student.BirthDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Please Wait....");
                    Thread.Sleep(1000);
                    if(StudentRepository.AddStudent(student))
                    {
                        Console.WriteLine("Student Added Successfully"); 
                    }
                    else
                    {
                        Console.WriteLine("The Student is already exist");
                    }
                        break;
                case 2:
                    Console.Write("For Updating please enter Student Email : ");
                    string Email = Console.ReadLine();
                    student = StudentRepository.Exist(Email);
                    if(student is null)
                    {
                        Console.WriteLine("There is no student with this email");
                        break;
                    }
                    int UpdateChoice;
                    do
                    {
                         UpdateChoice = StudentMenu.StudentUpdateMenu();
                        switch(UpdateChoice)
                        {
                            case 1:
                                Console.Write("Enter new Full Name : ");
                                student.FullName = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Enter new Email : ");
                                student.Email = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter new Phone : ");
                                student.Phone = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter new BirthDate (e.g., 25/05/2000): ");
                               student.BirthDate= DateTime.Parse(Console.ReadLine());
                                break;
                            case 0:
                                Console.WriteLine("Please Wait.....");
                                Thread.Sleep(1000);
                                break;

                        }
                        Console.WriteLine("Write 0 for exist , choose numb for continue");
                    } while (UpdateChoice != 0);
                    if(StudentRepository.UpdateStudent(student,Email))
                    {
                        Console.WriteLine("Updated Successfully");
                    }
                        break;

            }
        }
    }
}
