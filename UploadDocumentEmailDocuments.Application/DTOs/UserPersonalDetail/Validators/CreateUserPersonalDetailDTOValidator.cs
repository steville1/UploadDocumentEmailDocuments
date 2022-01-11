using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;

namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail.Validators
{
    
    public class CreateUserPersonalDetailDTOValidator : AbstractValidator<CreateUserPersonalDetailDTO>
    {
      public CreateUserPersonalDetailDTOValidator()
       {          
           Include(new IUserPersonalDetailDTOValidator());
       }       
    }
   
}
