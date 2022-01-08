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
    public class GetUserPersonalDetailListRequestHandler : IRequestHandler<GetUserPersonalDetailListRequest, List<UserPersonalDetailDTO>>
    {
        private readonly IUserPersonalDetail _userPersonalDetail;
        private readonly IMapper _mapper;

        public GetUserPersonalDetailListRequestHandler(IUserPersonalDetail userPersonalDetail,
             IMapper mapper)
        {
            _userPersonalDetail = userPersonalDetail;
            _mapper = mapper;
        }
  
        public async Task<List<UserPersonalDetailDTO>> Handle(GetUserPersonalDetailListRequest request, CancellationToken cancellationToken)
        {
            var user = await _userPersonalDetail.GetUserPersonalDetailWithFiles();
            return _mapper.Map<List<UserPersonalDetailDTO>>(user);
        }
    }
}
