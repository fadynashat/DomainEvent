﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salary.Infrastructure;

namespace Salary.Infrastructure.Migrations
{
    [DbContext(typeof(SalaryContext))]
    [Migration("20190728091515_int2")]
    partial class int2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:Sal.SalarySeq", "'SalarySeq', 'Sal', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Salary.Dmoain.AggregatesModel.EmployeeAggregate.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "SalarySeq")
                        .HasAnnotation("SqlServer:HiLoSequenceSchema", "Sal")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("EmpId");

                    b.Property<decimal>("Sal");

                    b.HasKey("Id");

                    b.ToTable("Salary");
                });
#pragma warning restore 612, 618
        }
    }
}