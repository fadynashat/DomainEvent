using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Salary.Dmoain.AggregatesModel.EmployeeAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Salary.Infrastructure.EntityConfigurations
{
   public class SalaryEntityTypeConfiguration: IEntityTypeConfiguration<Salary.Dmoain.AggregatesModel.EmployeeAggregate.Salary>
    {
        public void Configure(EntityTypeBuilder<Dmoain.AggregatesModel.EmployeeAggregate.Salary> EmpConfiguration)
        {


            EmpConfiguration.HasKey(o => o.Id);


            EmpConfiguration.Property(o => o.Id).ForSqlServerUseSequenceHiLo("SalarySeq", SalaryContext.DEFAULT_SCHEMA);

            EmpConfiguration.Property(o => o.Sal).IsRequired();


        }


    }
}
