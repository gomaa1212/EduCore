using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.View.Menus
{
    public static class StudentMenu
    {
        public static int studentMenu()
        {
            Console.WriteLine("==========Students========");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Get Student By Id");
            Console.WriteLine("5. Get All Students");
            Console.WriteLine("6. Search By Name");
            Console.WriteLine("7. Back");
            Console.Write("Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int StudentUpdateMenu()
        {
            Console.WriteLine("========Update Menu=======");
            Console.WriteLine("1. Full Name");
            Console.WriteLine("2. Email");
            Console.WriteLine("3. Phone");
            Console.WriteLine("4. Birth Date");
            Console.WriteLine("0. Exist");
            Console.Write("\nEnter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
