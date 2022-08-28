using Employee.Application.Commands;
using Employee.Application.Queries;
using Employee.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
      
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee.Core.Entities.AccountDetails>> Get()
        {
            return await _mediator.Send(new GetAllAccountQuery());
        }       
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AccountDetailsResponse>> CreateTransaction([FromBody] CreateAccountCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
