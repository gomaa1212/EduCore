using Azure.Core;
using EduCore.View.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Application.Services
{
    public static class MainService
    {
        public static void mainService()
        {
            int choice = MainMenu.mainMenu();
            if (choice == 1)
            {
                StudentService.studentService();
            }
            else if (choice == 0)
            {
                return;
            }
        }
    }
}
