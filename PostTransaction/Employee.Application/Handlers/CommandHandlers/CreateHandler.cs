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
    public class CreateHandler : IRequestHandler<CreateTransactionCommand, TransactionResponse>
    {
        private readonly ITransactionRepository _accountRepo;
        public CreateHandler(ITransactionRepository EmployeeRepository)
        {
            _accountRepo = EmployeeRepository;
        }
        public async Task<TransactionResponse> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var accountDetailsEntity = TransactionMapper.Mapper.Map<Employee.Core.Entities.TransactionDetails>(request);
            if (accountDetailsEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _accountRepo.AddAsync(accountDetailsEntity);
            var accountDetailsResponse = TransactionMapper.Mapper.Map<TransactionResponse>(newEmployee);
            return accountDetailsResponse;
        }
    }
}
