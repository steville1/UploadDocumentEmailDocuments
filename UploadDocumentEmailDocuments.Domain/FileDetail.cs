using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain.Common;

namespace UploadDocumentEmailDocuments.Domain
{
    public class FileDetail : BaseDomainEntity
    {
        public string UserId { get; set; }
        public string FileName { get; set; }
        public UserPersonalDetail UserPersonalDetail { get; set; }
    }
}
