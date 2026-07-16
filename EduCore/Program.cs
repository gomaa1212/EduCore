using EduCore.Application.Services;
using EduCore.View.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EduCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainService.mainService();
        }
    }
   
}
