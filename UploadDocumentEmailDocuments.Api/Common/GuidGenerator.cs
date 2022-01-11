using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadDocumentEmailDocuments.Api.Common
{
    public static class GuidGenerator
    {
        public static string guid()
        {
            Guid obj = Guid.NewGuid();
            return obj.ToString();
        }
    }
}
