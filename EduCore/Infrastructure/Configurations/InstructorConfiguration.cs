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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructor",t=>t.HasCheckConstraint("CK_Instructor_Salary_Min", "[Salary] > 0"));
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Email).IsRequired().HasMaxLength(150);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.Property(x => x.Salary)
                   .HasColumnType("decimal(10,2)");
            builder.Property(x => x.HireDate).IsRequired();
            builder.HasOne(x => x.Department)
                .WithMany(x => x.Instructors)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
                
        }
    }
}
