using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;

namespace UploadDocumentEmailDocuments.Application.DTOs.FileDetail.Validators
{
    
    public class CreateFileDetailDTOValidator : AbstractValidator<CreateFileDetailDTO>
    {
        private readonly IFileDetail _fileDetail;

        public CreateFileDetailDTOValidator(IFileDetail fileDetail)
        {
            _fileDetail = fileDetail;
            Include(new CreateFileDetailDTOValidator(_fileDetail));
        }
    }
}
