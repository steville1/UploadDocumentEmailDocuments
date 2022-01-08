using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Queries
{
    public class GetUserPersonalDetailRequest : IRequest<UserPersonalDetailDTO>
    {
        public int Id { get; set; }
    }
}
