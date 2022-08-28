using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Employee.Core.Entities.TransactionDetails>
    {
        //custom operations here
        Task<IEnumerable<Employee.Core.Entities.TransactionDetails>> GetTransactionDetails(Int64 TransactionID);
    }
}
