using EduCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course",x=>
            {
                x.HasCheckConstraint("CK_Course_Hours_Min", "[Hours] > 0");
                x.HasCheckConstraint("CK_Course_Price_Min", "[Price] >=0");
             });
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Description).HasColumnType("nvarchar(500)");
            builder.Property(x => x.Hours).HasColumnName("Hours");
            builder.Property(x => x.Price)
                   .HasColumnType("decimal(10,2)");
            builder.HasOne(x => x.Department)
                .WithMany(x => x.Courses)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Instructor)
                .WithMany(x => x.Courses)
                .HasForeignKey(x => x.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
