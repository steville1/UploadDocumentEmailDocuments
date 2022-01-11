using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;

namespace UploadDocumentEmailDocuments.Application.DTOs.FileDetail
{
    public class CreateFileDetailDTO : IFileDetailDTO
    {
        public int UsersPersonalDetailId { get; set; }
        public string FileName { get; set; }
        //public CreateUserPersonalDetailDTO UsersPersonalDetailDTO { get; set; }
        public UserPersonalDetailDTO UserPersonalDetailDTO { get; set; }
    }
}
