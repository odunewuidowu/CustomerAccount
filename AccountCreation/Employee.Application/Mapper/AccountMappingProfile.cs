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
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<Employee.Core.Entities.AccountDetails, AccountDetailsResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.AccountDetails, CreateAccountCommand>().ReverseMap();
        }
    }
}
