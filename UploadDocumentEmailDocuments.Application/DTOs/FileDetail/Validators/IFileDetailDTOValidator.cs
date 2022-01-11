using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;

namespace UploadDocumentEmailDocuments.Application.DTOs.FileDetail.Validators
{
    public class IFileDetailDTOValidator : AbstractValidator<IFileDetailDTO>
    {
        

        public IFileDetailDTOValidator()
        {
             RuleFor(p => p.UsersPersonalDetailId).NotEmpty().WithMessage("UserId Must Be Entered");
        }
    }
}
