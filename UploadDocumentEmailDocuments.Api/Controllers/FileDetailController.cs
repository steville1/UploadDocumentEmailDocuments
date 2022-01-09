using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.FileDetail;
using UploadDocumentEmailDocuments.Application.Features.FileDetail.Requests.Command;

namespace UploadDocumentEmailDocuments.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FileDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

       // POST api/<FileDetailController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateFileDetailDTO fileDetail)
        {
            var command = new CreateFileDetailCommand { FileDetailDTO = fileDetail };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


    }
}
