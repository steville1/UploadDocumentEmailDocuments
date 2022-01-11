using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;
using UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Requests.Queries;

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Handlers.Queries
{
    //class GetUserPersonalDetailRequestHandler
    public class GetUserPersonalDetailRequestHandler : IRequestHandler<GetUserPersonalDetailRequest, UserPersonalDetailDTO>
    {
        private readonly IUserPersonalDetail _userPersonalDetail;
        private readonly IMapper _mapper;

        public GetUserPersonalDetailRequestHandler(IUserPersonalDetail userPersonalDetail,
             IMapper mapper)
        {
            _userPersonalDetail = userPersonalDetail;
            _mapper = mapper;
        }
        public async Task<UserPersonalDetailDTO> Handle(GetUserPersonalDetailRequest request, CancellationToken cancellationToken)
        {
            var user = await _userPersonalDetail.GetUserPersonalDetailWithFiles(request.Id);
            var map = _mapper.Map<UserPersonalDetailDTO>(user);
            return map;
        }
    }
}
