using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;
using UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Command;
using UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Queries;

namespace UploadDocumentEmailDocuments.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserPersonalDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserPersonalDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<UserPersonalDetailController>
        [HttpGet]
        public async Task<ActionResult<List<UserPersonalDetailDTO>>> Get()
        {
            var users = await _mediator.Send(new GetUserPersonalDetailListRequest());
            return Ok(users);
        }

        // GET api/<UserPersonalDetailController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserPersonalDetailDTO>> Get(int id)
        {
            var user = await _mediator.Send(new GetUserPersonalDetailRequest { Id = id });
            return Ok(user);
        }

        // POST api/<UserPersonalDetailController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateUserPersonalDetailDTO userPersonalDetail)
        {
            var command = new CreateUserPersonalDetailCommand { UsersPersonalDetailDTO = userPersonalDetail };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

       
    }
}
