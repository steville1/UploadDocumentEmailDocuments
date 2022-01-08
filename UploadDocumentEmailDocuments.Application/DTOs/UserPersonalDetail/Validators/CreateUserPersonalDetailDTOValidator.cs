using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;

namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail.Validators
{
    //class CreateUserPersonalDetailDTOValidator
    public class CreateUserPersonalDetailDTOValidator : AbstractValidator<CreateUserPersonalDetailDTO>
    {
        private readonly IUserPersonalDetail _userPersonalDetail;

        public CreateUserPersonalDetailDTOValidator(IUserPersonalDetail userPersonalDetail)
        {
            _userPersonalDetail = userPersonalDetail;
            Include(new CreateUserPersonalDetailDTOValidator(_userPersonalDetail));
        }
    }
}
