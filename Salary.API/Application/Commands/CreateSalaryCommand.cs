using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.API.Application.Commands
{
    public class CreateSalaryCommand : IRequest<bool>
    {
        public int EmpId { get; set; }
        public Decimal Salary { get; set; }

        public CreateSalaryCommand()
        {

        }
        public CreateSalaryCommand(int empId , Decimal salary)
        {
            EmpId = empId;
            Salary = salary;
        }
    }
}
