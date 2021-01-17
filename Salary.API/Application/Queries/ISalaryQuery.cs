﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary.API.Application.Queries
{
   public interface ISalaryQueries
   {
            Task<SalaryView> GetSalaryAsync(int id);

            Task<IEnumerable<SalaryView>> GetAllSalaryAsync();
   }
    
}
