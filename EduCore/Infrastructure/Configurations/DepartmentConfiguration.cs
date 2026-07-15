using EduCore.Domain.Entities;
using EduCore.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(x=>x.Id);
            builder.Property(x=> x.Name).IsRequired(true).HasMaxLength(100);
            builder.HasIndex(x=>x.Name).IsUnique();
            builder.Property(x=>x.Description).IsRequired(false).HasMaxLength(300);
            builder.HasData(DepartmentSeed.GetDepartmentData());
        }
    }
}
