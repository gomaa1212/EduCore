using EduCore.Domain.Entities;
using EduCore.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Configurations
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("Enrollment",x=>x.HasCheckConstraint("CK_Enrollment_Progress_Range","[Progress] >=0 AND [Progress] <=100"));
            builder.HasKey(x => new { x.StudentId, x.CourseId });
            builder.Property(x => x.EnrollDate).IsRequired();
            builder.Property(x => x.Status)
                .HasConversion(
                    x => x.ToString(),
                    x => (EnrollmentStatus)Enum.Parse(typeof(EnrollmentStatus), x)
                    );
            builder.Property(x => x.Progress).HasDefaultValue(0);
            builder.Property(x => x.EnrollDate)
                    .HasDefaultValueSql("GETDATE()");
            builder.HasOne(x=>x.Student)
                .WithMany(x=>x.Enrollments)
                .HasForeignKey(x=>x.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Course)
                .WithMany(x=>x.Enrollments)
                .HasForeignKey(x=>x.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
