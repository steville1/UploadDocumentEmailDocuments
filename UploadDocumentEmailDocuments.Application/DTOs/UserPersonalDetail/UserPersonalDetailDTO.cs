using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.Common;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail
{
    public class UserPersonalDetailDTO : BaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public ICollection<FileDetail> fileDetails { get; set; }
    }
}
