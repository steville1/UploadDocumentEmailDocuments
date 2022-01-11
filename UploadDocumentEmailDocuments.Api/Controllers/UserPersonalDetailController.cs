using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Api.Common;
using UploadDocumentEmailDocuments.Application.DTOs.FileDetail;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;
using UploadDocumentEmailDocuments.Application.Features.FileDetail.Requests.Command;
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
        [Route("GetAllUsersPersonalDetail")]
        [HttpGet]
        public async Task<ActionResult<List<UserPersonalDetailDTO>>> GetUserPersonalDetailById()
        {
            var users = await _mediator.Send(new GetUserPersonalDetailListRequest());
            return Ok(users);
        }

        // GET api/<UserPersonalDetailController>/5
        [Route("GetUserPersonalDetailById/{id}")]
        [HttpGet]
        public async Task<ActionResult<UserPersonalDetailDTO>> GetUserPersonalDetailById(int id)
        {
            var user = await _mediator.Send(new GetUserPersonalDetailRequest { Id = id });
            return Ok(user);
        }
        // GET api/<UserPersonalDetailController>/5
        [Route("GetByEmailAddressAndReferenceNo/{email}/{refNo}")]
        [HttpGet]
        public async Task<ActionResult<UserPersonalDetailDTO>> GetByEmailAddressAndReferenceNo(string email, string refNo)
        {
            var user = await _mediator.Send(new GetUserPersonalDetailByEmailAndRefNoRequest { Email = email, ReferenceNumber = refNo });
            return Ok(user);
        }

        // POST api/<UserPersonalDetailController>
        [Route("AddUserPersonalDetails")]
        [HttpPost]
        public async Task<ActionResult> AddUserPersonalDetails(IFormFile[] files, string Name, string Email, string Phone, string Age)
        {
            var userPersonalDetail = new CreateUserPersonalDetailDTO
            {
                    ReferenceNumber = GuidGenerator.guid(),
                    Age = Age,
                    Email = Email,
                    Name = Name,
                    Phone = Phone
            };
            //To enhance this functionality ensure the photos are stored in the cloud AWS S3 or Azure
            var documentList = FileUploadHelper.MultipleFileUpload(files);
            
            var commandUsers = new CreateUserPersonalDetailCommand { UserPersonalDetailDTO = userPersonalDetail };
           
            var response = await _mediator.Send(commandUsers);
            
            foreach (var item in documentList)
            {
                var fileDetail = new CreateFileDetailDTO
                {
                    FileName = item,
                    UsersPersonalDetailId= response.Id,
                };
                var commandFiles = new CreateFileDetailCommand { FileDetailDTO = fileDetail };
                await _mediator.Send(commandFiles);
            }

            return Ok(response);
        }

       
    }
}
