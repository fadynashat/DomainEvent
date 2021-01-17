using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.API.Application.Commands
{
    public class UpdateSalaryCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public Decimal Salary { get; set; }

        public UpdateSalaryCommand()
        {

        }
        public UpdateSalaryCommand(int empId , Decimal salary)
        {
            EmpId = empId;
            Salary = salary;
        }
    }
}
