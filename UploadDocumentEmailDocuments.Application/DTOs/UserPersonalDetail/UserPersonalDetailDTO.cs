using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.Common;
using UploadDocumentEmailDocuments.Application.DTOs.FileDetail;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail
{
    public class UserPersonalDetailDTO : BaseDto
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public ICollection<FileDetailDTO> fileDetails { get; set; }
       
    }
}
