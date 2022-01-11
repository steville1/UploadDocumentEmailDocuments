using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.FileDetail;
using UploadDocumentEmailDocuments.Application.Responses;

namespace UploadDocumentEmailDocuments.Application.Features.FileDetail.Requests.Command
{
    //class CreateFileDetailCommand
    // {
    // }
    public class CreateFileDetailCommand : IRequest<BaseCommandResponse>
    {
        public CreateFileDetailDTO FileDetailDTO { get; set; }
    }
}
