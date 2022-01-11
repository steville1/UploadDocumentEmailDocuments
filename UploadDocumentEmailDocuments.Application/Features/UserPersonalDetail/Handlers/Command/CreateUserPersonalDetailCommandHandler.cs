using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail.Validators;
using UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Command;
using UploadDocumentEmailDocuments.Application.Exceptions;
using UploadDocumentEmailDocuments.Application.Responses;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Handlers.Command
{
    public class CreateUserPersonalDetailCommandHandler : IRequestHandler<CreateUserPersonalDetailCommand, BaseCommandResponse>
    {
        private readonly IUserPersonalDetail _userPersonalDetail;
        private readonly IMapper _mapper;

        public CreateUserPersonalDetailCommandHandler(
            IUserPersonalDetail userPersonalDetail,
            IMapper mapper)
        {
            _userPersonalDetail = userPersonalDetail;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateUserPersonalDetailCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateUserPersonalDetailDTOValidator();
            var validationResult = await validator.ValidateAsync(request.UserPersonalDetailDTO);
            //if()
            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
               // return response;
            }
            else
            {
                var user = _mapper.Map<UsersPersonalDetail>(request.UserPersonalDetailDTO);
                user = await _userPersonalDetail.Add(user);
                response.Id = user.Id;
                response.ReferenceNumber = user.ReferenceNumber;
                response.Success = true;
                response.Message = "Creation Successful";
            }
            
            return response;

            
        }
    }
}
