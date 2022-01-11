using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;
using UploadDocumentEmailDocuments.Application.Responses;

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Queries
{
    public class GetUserPersonalDetailByEmailAndRefNoRequest : IRequest<BaseRequestResponse>
    {
     public string Email { get; set; }
     public string ReferenceNumber { get; set; }
    }
}
