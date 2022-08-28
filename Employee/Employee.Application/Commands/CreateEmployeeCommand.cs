using Employee.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public string AccountType
        {
            get;
            set;
        }
        public string Surname
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string Firstname
        {
            get;
            set;
        }
        public string MiddleName
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string EmailAddress
        {
            get;
            set;
        }
        public string StreetName
        {
            get;
            set;
        }
        public string HouseNumber
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string PostalCode
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string MaritalStatus
        {
            get;
            set;
        }
        public bool IsTermAgreed
        {
            get;
            set;
        }
        public DateTime DateCreated
        {
            get;
            set;
        }
        public string SignatureURL
        {
            get;
            set;
        }
        public double CurrentBalance
        {
            get;
            set;
        }
        public double BookBalance
        {
            get;
            set;
        }
        public Int64 AccountNumber
        {
            get;
            set;
        }
        public string AccountName
        {
            get;
            set;
        }
        public string BranchLocation
        {
            get;
            set;
        }
    }
}
