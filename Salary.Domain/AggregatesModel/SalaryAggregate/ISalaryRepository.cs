using Salary.Dmoain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Salary.Dmoain.AggregatesModel.EmployeeAggregate
{
    public interface ISalaryRepository : IRepository<Salary>
    {
        Salary Add(Salary salary);

        void Update(Salary salary);

        Task<Salary> GetAsync(int salaryId);

        void Delete(int id);
    }
}
