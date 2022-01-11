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
        public CreateFileDetailDTOValidator()
        {          
            Include(new IFileDetailDTOValidator());
        }
    }
}
