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
    public class CreateTransHandler : IRequestHandler<CreateTransactionCommand, TransactionResponse>
    {
        private readonly ITransactionRepository _transactionRepo;
        public CreateTransHandler(ITransactionRepository employeeRepository)
        {
            _transactionRepo = employeeRepository;
        }
        public async Task<TransactionResponse> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var transactionDetails = TransactionMapper.Mapper.Map<Employee.Core.Entities.TransactionDetails>(request);
            if (transactionDetails is null)
            {
                throw new ApplicationException("Issue with transaction mapper");
            }
            var newTransaction = await _transactionRepo.AddAsync(transactionDetails);
            var transactionResponse = TransactionMapper.Mapper.Map<TransactionResponse>(newTransaction);
            return transactionResponse;
        }
    }
}
