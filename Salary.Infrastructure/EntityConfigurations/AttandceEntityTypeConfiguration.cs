using Microsoft.EntityFrameworkCore;
using Salary.Domain.AggregatesModel.AttendanceAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Salary.Infrastructure.EntityConfigurations
{
    public class AttandceEntityTypeConfiguration : IEntityTypeConfiguration<Attendance>
    {
       
      

        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable("Attendance", SalaryContext.DEFAULT_SCHEMA);
            builder.HasKey(o => o.Id);
            builder.Property<string>("days").IsRequired(false);
        }
    }
}
