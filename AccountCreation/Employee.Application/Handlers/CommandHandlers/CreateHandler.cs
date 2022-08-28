using Employee.Application.Commands;
using Employee.Application.Mapper;
using Employee.Application.Responses;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers.CommandHandlers
{
    public class CreateHandler : IRequestHandler<CreateAccountCommand, AccountDetailsResponse>
    {
        private readonly IAccountRepository _accountRepo;
        public CreateHandler(IAccountRepository employeeRepository)
        {
            _accountRepo = employeeRepository;
        }
        public async Task<AccountDetailsResponse> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var accountDetailsEntity = AccountMapper.Mapper.Map<Employee.Core.Entities.AccountDetails>(request);
            if (accountDetailsEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _accountRepo.AddAsync(accountDetailsEntity);
            var accountDetailsResponse = AccountMapper.Mapper.Map<AccountDetailsResponse>(newEmployee);
            return accountDetailsResponse;
        }
    }
}
