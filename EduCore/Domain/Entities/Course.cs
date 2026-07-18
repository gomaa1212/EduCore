using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public int Hours { get; set; }
        public decimal Price { get; set; }
        public int DepartmentId { get; set; }
        public int InstructorId { get; set; }
        public Department? Department { get; set; }
        public Instructor? Instructor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public override string ToString()
        {
            return $"[Id: {Id,-5} | Title: {Title,-25} | Hours: {Hours,-3} hrs | Price: {Price,-8:C} | DeptId: {DepartmentId,-4} | InstructorId: {InstructorId,-4}]";
        }
    }
}
