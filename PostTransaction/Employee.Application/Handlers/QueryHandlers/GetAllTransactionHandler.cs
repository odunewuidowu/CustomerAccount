using Employee.Application.Queries;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers.QueryHandlers
{
    public class GetAllTransactionHandler : IRequestHandler<GetAllTransactionQuery, List<Employee.Core.Entities.TransactionDetails>>
    {
        private readonly ITransactionRepository _EmployeeRepo;

        public GetAllTransactionHandler(ITransactionRepository EmployeeRepository)
        {
            _EmployeeRepo = EmployeeRepository;
        }
        public async Task<List<Core.Entities.TransactionDetails>> Handle(GetAllTransactionQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.TransactionDetails>)await _EmployeeRepo.GetAllAsync();
        }
    }
}
