using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Mapper
{
    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<Employee.Core.Entities.TransactionDetails, TransactionResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.TransactionDetails, CreateTransactionCommand>().ReverseMap();
        }
    }
}
