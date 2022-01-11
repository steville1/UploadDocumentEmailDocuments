using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain.Common;

namespace UploadDocumentEmailDocuments.Domain
{
    public class UsersPersonalDetail : BaseDomainEntity
    {
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public ICollection<FilesDetail> fileDetails { get; set; }
    }
}
