using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Queries
{
    public class GetAllAccountQuery : IRequest<List<Employee.Core.Entities.AccountDetails>>
    {

    }
}
