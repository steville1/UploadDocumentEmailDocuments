using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail;

namespace UploadDocumentEmailDocuments.Application.Responses
{
    public class BaseRequestResponse
    {
         public UserPersonalDetailDTO UserPersonalDetailDTO { get; set; }
         public Boolean Success { get; set; }
         public string Message { get; set; }
    }
}
