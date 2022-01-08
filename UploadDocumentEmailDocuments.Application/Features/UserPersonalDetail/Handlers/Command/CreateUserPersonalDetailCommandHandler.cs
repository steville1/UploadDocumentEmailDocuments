using AutoMapper;
using FluentValidation;
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

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Handlers.Command
{
    //class CreateUserPersonalDetailCommandHandler
    public class CreateUserPersonalDetailCommandHandler : IRequestHandler<CreateUserPersonalDetailCommand, int>
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

        public async Task<int> Handle(CreateUserPersonalDetailCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateUserPersonalDetailDTOValidator(_userPersonalDetail);
            var validationResult = await validator.ValidateAsync(request.UserPersonalDetailDTO);

            if (validationResult.IsValid == false)
                throw new ValidationException((IEnumerable<FluentValidation.Results.ValidationFailure>)validationResult);

            var user = _mapper.Map<UsersPersonalDetail>(request.UserPersonalDetailDTO);

            user = await _userPersonalDetail.Add(user);

            return user.Id;
        }
    }
}
