using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;

namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail.Validators
{
    
    public class IUserPersonalDetailDTOValidator : AbstractValidator<IUserPersonalDetailDTO>
    {
        private readonly IUserPersonalDetail _userPersonalDetail;

        public IUserPersonalDetailDTOValidator(IUserPersonalDetail userPersonalDetail)
        {
            _userPersonalDetail = userPersonalDetail;
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name must be enter");
            RuleFor(p => p.Email).EmailAddress().NotEmpty().WithMessage("Field must be email value and must be entered");

        }
    }
}
