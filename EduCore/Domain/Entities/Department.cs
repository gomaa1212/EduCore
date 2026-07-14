using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Course>? Courses { get; set; }=new List<Course>();
        public ICollection<Instructor>? Instructors { get; set; }=new List<Instructor>();

    }
}
