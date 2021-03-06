﻿using Microsoft.EntityFrameworkCore;
using Salary.Dmoain.SeedWork;
using Salary.Domain.AggregatesModel.AttendanceAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Infrastructure.Repository
{
    public class AttandceRepsoitory : IAttandceRepository
    {


        private readonly SalaryContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }


        public AttandceRepsoitory(SalaryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public Attendance Add(Attendance attendance)
        {
            return _context.Attandance.Add(attendance).Entity;

        }

        public void Delete(int id)
        {
            var employee = _context.Attandance.Find(id);
            _context.Attandance.Remove(employee);
        }

        public async Task<Attendance> GetAsync(int attendanceId)
        {
            var Attandance = await _context.Attandance.FindAsync(attendanceId);
            if (Attandance != null)
            {
                await _context.Entry(Attandance).Reference(i => i.days).LoadAsync();
            }

            return Attandance;
        }

        public void Update(Attendance attendance)
        {
            _context.Entry(attendance).State = EntityState.Modified;

        }
    }
}
