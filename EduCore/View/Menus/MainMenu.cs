using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.View.Menus
{
    public static class MainMenu
    {
        public static int mainMenu()
        {
            Console.WriteLine("===============WELCOME TO EDUCORE===============");
            Console.WriteLine("1. Students");
            Console.WriteLine("2. Courses");
            Console.WriteLine("3. Instructors");
            Console.WriteLine("4. Departments");
            Console.WriteLine("5. Enrollments");
            Console.WriteLine("0. Exist");
            Console.WriteLine();
            Console.Write("Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
