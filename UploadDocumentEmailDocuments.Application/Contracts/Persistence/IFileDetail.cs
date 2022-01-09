using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Application.Contracts.Persistence
{
    public interface IFileDetail : IGenericRepository<FilesDetail>
    {
        //Task<UsersPersonalDetail> GetUserPersonalDetailWithFiles(int id);
       // Task<List<UsersPersonalDetail>> GetUserPersonalDetailWithFiles();
    }
}
