using Salary.Dmoain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salary.Dmoain.AggregatesModel.EmployeeAggregate
{
    public class Salary : Entity, IAggregateRoot
    {

        public int EmpId { get; private set; }
        public decimal Sal { get; private set; }


        public Salary()
        {

        }

        public Salary(int _EmpId, decimal _Sal)
        {
            EmpId = _EmpId;
            Sal = _Sal;
        }


        public void UpdateSalary(decimal salary)
        {
            Sal = salary;
        }
    }
}
