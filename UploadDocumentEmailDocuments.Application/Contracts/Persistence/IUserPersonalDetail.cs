using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.Contracts.Persistence
{
    public interface IUserPersonalDetail : IGenericRepository<UsersPersonalDetail>
    {
        Task<UsersPersonalDetail> GetUserPersonalDetailWithFiles(int id);
        Task<UsersPersonalDetail> GetUserPersonalByEmailAndReferenceNo(string email, string referenceNo);
        Task<List<UsersPersonalDetail>> GetUserPersonalDetailWithFiles();
    }
}
