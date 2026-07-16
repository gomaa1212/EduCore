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
        public  string FullName { get; set; }
        public  string Email { get; set; }
        public  string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }=new List<Enrollment>();
        public override string ToString()
        {
            return $"Id: {Id}          , Name: {FullName}     , Email: {Email}    , Phone: {Phone}     , BirthDate: {BirthDate.ToShortDateString()}     , RegisterDate: {RegisterDate.ToShortDateString()}         ";
        }

    }
}
