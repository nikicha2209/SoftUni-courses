using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);
            builder.Property(c => c.Name).HasColumnType("NVARCHAR(80)").IsRequired();
            builder.Property(c => c.Description).IsUnicode().IsRequired(false);
            
            builder.HasMany(c=>c.Resources).WithOne(c => c.Course).HasForeignKey(c=>c.CourseId);
            builder.HasMany(c=>c.Homeworks).WithOne(c=>c.Course).HasForeignKey(c=>c.CourseId);
        }
    }
}
