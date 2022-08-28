using Employee.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Commands
{
    public class CreateTransactionCommand : IRequest<TransactionResponse>
    {
        public Int64 TransactionID
        {
            get;
            set;
        }
        public Int64 AccountID
        {
            get;
            set;
        }
        public DateTime DateCreated
        {
            get;
            set;
        }
        public string TransactionType
        {
            get;
            set;
        }
        public double Amount
        {
            get;
            set;
        }
    }
}
