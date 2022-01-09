using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region UserPersonalDetails Mappings
            CreateMap<UsersPersonalDetail, UserPersonalDetailDTO>().ReverseMap();
            CreateMap<UsersPersonalDetail, CreateUserPersonalDetailDTO>().ReverseMap();

            #endregion UserPersonalDetails

            // CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            // CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();

        }
    }
}
