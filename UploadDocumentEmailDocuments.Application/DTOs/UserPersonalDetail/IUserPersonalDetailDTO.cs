using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail
{
    public interface IUserPersonalDetailDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
    }
}
