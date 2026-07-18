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
                var StudentRepository = new StudentRepository();
                var student = new Student();
                int choice = StudentMenu.studentMenu();
                switch (choice)
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
                        if (StudentRepository.AddStudent(student))
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
                        if (student is null)
                        {
                            Console.WriteLine("There is no student with this email");
                            break;
                        }
                        int UpdateChoice;
                        do
                        {
                            UpdateChoice = StudentMenu.StudentUpdateMenu();
                            switch (UpdateChoice)
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
                                    student.BirthDate = DateTime.Parse(Console.ReadLine());
                                break;
                                case 0:
                                    Console.WriteLine("Please Wait.....");
                                    Thread.Sleep(1000);
                                break;

                            }
                            Console.WriteLine("Write 0 for exist , choose numb for continue");
                        } while (UpdateChoice != 0);
                        if (StudentRepository.UpdateStudent(student, Email))
                        {
                            Console.WriteLine("Updated Successfully");
                        }
                    break;
                    case 3:
                        Console.Write("Enter Student Id : ");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Wait..");
                        if (StudentRepository.DeleteStudent(Id))
                        {
                            Console.WriteLine("Student Deleted Successfuly");
                        }
                        else
                        {
                            Console.WriteLine("Student doesn't exist");
                        }
                    break;
                    case 4:
                        Console.Write("Enter Student Id : ");
                        int StudentId = int.Parse(Console.ReadLine());
                        var GetStudent = StudentRepository.GetById(StudentId);
                    if (GetStudent is null)
                    {
                        Console.WriteLine("There is no studend with this id");
                    }
                    else
                    {
                        Console.WriteLine("\nThe student Details is \n");
                        Console.WriteLine(GetStudent);
                    }
                    break;
                    case 5:
                        Console.Write("Enter page number : ");
                        int page = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        while (page != 0)
                        {
                            var students = StudentRepository.GetAll(page, 5);
                        if (!students.Any())
                        {
                            Console.WriteLine($"\n--- No students found at page {page} ---\n");
                            if (page>1)
                            {
                                page--;
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"==================== PAGE {page} ====================");
                            Console.WriteLine(new string('-', 75));
                            foreach (var s in students)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine();
                            Console.Write("Press > For next Page and < for previous page and anything for exist : ");
                            char press = char.Parse(Console.ReadLine());
                            if (press == '>')
                            {
                                page++;
                            }
                            else if(press =='<')
                            {
                                page--;
                            }
                            else
                            {
                                break;
                            }
                            Console.Clear();
                        }
                        }
                    break;
                    case 6:
                        Console.Write("Enter name  : ");
                        string Name = Console.ReadLine();
                        var result = StudentRepository.SearchByName(Name);
                    if (!result.Any())
                    {
                        Console.WriteLine("There is no students with this name");
                    }
                    else
                    {
                        foreach (var s in result)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    break;
                    case 7:
                        MainService.mainService();
                    break;
                }
            }
      }
}
