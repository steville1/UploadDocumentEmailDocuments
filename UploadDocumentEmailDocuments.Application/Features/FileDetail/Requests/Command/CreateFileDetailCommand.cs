using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.FileDetail;

namespace UploadDocumentEmailDocuments.Application.Features.FileDetail.Requests.Command
{
    //class CreateFileDetailCommand
    // {
    // }
    public class CreateFileDetailCommand : IRequest<int>
    {
        public CreateFileDetailDTO FileDetailDTO { get; set; }
    }
}
