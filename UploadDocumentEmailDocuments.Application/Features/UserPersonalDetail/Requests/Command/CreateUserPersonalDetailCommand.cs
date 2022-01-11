using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;
using UploadDocumentEmailDocuments.Application.Responses;

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Command
{
    
    public class CreateUserPersonalDetailCommand : IRequest<BaseCommandResponse>
    {
        public CreateUserPersonalDetailDTO UserPersonalDetailDTO { get; set; }
    }
}
