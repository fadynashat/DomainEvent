using System;
using System.Collections.Generic;
using System.Text;
using Salary.Dmoain.SeedWork;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Salary.Infrastructure;
using Salary.Dmoain.AggregatesModel.EmployeeAggregate;
using System.Threading;

namespace Salary.Infrastructure.Repository
{
    public class SalaryRepository : ISalaryRepository
    {


        private readonly SalaryContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public SalaryRepository(SalaryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }
        public Salary.Dmoain.AggregatesModel.EmployeeAggregate.Salary Add(Salary.Dmoain.AggregatesModel.EmployeeAggregate.Salary employee)
        {
            return _context.Salary.Add(employee).Entity;
        }

        public async Task<Salary.Dmoain.AggregatesModel.EmployeeAggregate.Salary> GetAsync(int employeeId)
        {
            var employee = await _context.Salary.FindAsync(employeeId);


            return employee;
        }

        public void Update(Salary.Dmoain.AggregatesModel.EmployeeAggregate.Salary salary)
        {
            _context.Entry(salary).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var salary = _context.Salary.Find(id);
            _context.Salary.Remove(salary);
        }
    }
}
