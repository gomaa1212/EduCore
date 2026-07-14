using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }=new List<Enrollment>();

    }
}
