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
    public class GetAllAccountHandler : IRequestHandler<GetAllAccountQuery, List<Employee.Core.Entities.AccountDetails>>
    {
        private readonly IAccountRepository _EmployeeRepo;

        public GetAllAccountHandler(IAccountRepository EmployeeRepository)
        {
            _EmployeeRepo = EmployeeRepository;
        }
        public async Task<List<Core.Entities.AccountDetails>> Handle(GetAllAccountQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.AccountDetails>)await _EmployeeRepo.GetAllAsync();
        }
    }
}
