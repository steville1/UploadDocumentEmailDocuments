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
using UploadDocumentEmailDocuments.Application.Responses;

namespace UploadDocumentEmailDocuments.Application.Features.UserPersonalDetail.Handlers.Queries
{
   
    public class GetUserPersonalDetailByEmailAndRefNoRequestHandler : IRequestHandler<GetUserPersonalDetailByEmailAndRefNoRequest, BaseRequestResponse>
    {
        private readonly IUserPersonalDetail _userPersonalDetail;
        private readonly IMapper _mapper;

        public GetUserPersonalDetailByEmailAndRefNoRequestHandler(IUserPersonalDetail userPersonalDetail,
             IMapper mapper)
        {
            _userPersonalDetail = userPersonalDetail;
            _mapper = mapper;
        }
        public async Task<BaseRequestResponse> Handle(GetUserPersonalDetailByEmailAndRefNoRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseRequestResponse();
            var user = await _userPersonalDetail.GetUserPersonalByEmailAndReferenceNo(request.Email, request.ReferenceNumber);
            var userDetails= _mapper.Map<UserPersonalDetailDTO>(user);
            if(userDetails !=null)
            {
                response.Success = true;
                response.Message = "Details Of Users Successfully Retrieved";
                response.UserPersonalDetailDTO = userDetails;        
            }
            else
            {
                response.Success = false;
                response.Message = "Details Of Users Not Found";
            }
            return response;
            
        }
    }
}
