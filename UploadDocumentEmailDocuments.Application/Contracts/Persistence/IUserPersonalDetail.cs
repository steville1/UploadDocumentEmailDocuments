using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.Contracts.Persistence
{
    public interface IUserPersonalDetail : IGenericRepository<UserPersonalDetail>
    {
        Task<UserPersonalDetail> GetUserPersonalDetailWithFiles(int id);
        Task<List<UserPersonalDetail>> GetUserPersonalDetailWithFiles();
    }
}
