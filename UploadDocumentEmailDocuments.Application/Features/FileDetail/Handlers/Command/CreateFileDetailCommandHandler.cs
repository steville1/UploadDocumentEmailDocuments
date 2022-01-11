using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;
using UploadDocumentEmailDocuments.Application.DTOs.FileDetail.Validators;
using UploadDocumentEmailDocuments.Application.Exceptions;
using UploadDocumentEmailDocuments.Application.Features.FileDetail.Requests.Command;
using UploadDocumentEmailDocuments.Application.Responses;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.Features.FileDetail.Handlers.Command
{
    public class CreateFileDetailCommandHandler : IRequestHandler<CreateFileDetailCommand, BaseCommandResponse>
    {
        private readonly IFileDetail _fileDetail;
        private readonly IMapper _mapper;

        public CreateFileDetailCommandHandler(
            IFileDetail fileDetail,
            IMapper mapper)
        {
            _fileDetail = fileDetail;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateFileDetailCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateFileDetailDTOValidator();
            var validationResult = await validator.ValidateAsync(request.FileDetailDTO);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
                // return response;
            }

           

            var file = _mapper.Map<FilesDetail>(request.FileDetailDTO);

            file = await _fileDetail.Add(file);

            return response;
        }
    }
}
