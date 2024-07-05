using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);
            builder.Property(s => s.Name).HasColumnType("NVARCHAR(100)");
            builder.Property(s => s.PhoneNumber).IsRequired(false).HasColumnType("CHAR(10)");
            builder.Property(s => s.Birthday).IsRequired(false);
            
        }
    }
}
