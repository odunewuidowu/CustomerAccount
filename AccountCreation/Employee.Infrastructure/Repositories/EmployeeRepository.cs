using Employee.Core.Repositories;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee.Core.Entities.AccountDetails>, IAccountRepository
    {
        public EmployeeRepository(AccountContext EmployeeContext) : base(EmployeeContext)
        {

        }
       
        public async Task<IEnumerable<Core.Entities.AccountDetails>> GetEmployeeByLastName(string Surname)
        {
            return await _EmployeeContext.AccountDetails
                .Where(m => m.Surname == Surname)
                .ToListAsync();
        }
    }
}
