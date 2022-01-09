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
        private readonly IFileDetail _fileDetail;

        public IFileDetailDTOValidator(IFileDetail fileDetail)
        {
            _fileDetail = fileDetail;
            RuleFor(p => p.UserId).NotEmpty().WithMessage("UserId Must Be Entered");
        }
    }
}
