using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IAccountRepository : IRepository<Employee.Core.Entities.AccountDetails>
    {
        //custom operations here
        Task<IEnumerable<Employee.Core.Entities.AccountDetails>> GetEmployeeByLastName(string lastname);
    }
}
