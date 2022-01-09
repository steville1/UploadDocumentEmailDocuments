using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Persistence.Repositories
{
    public class FileDetailRepository : GenericRepository<FilesDetail>, IFileDetail
    {
        private readonly UploadDocumentEmailDocumentsDbContext _dbContext;

        public FileDetailRepository(UploadDocumentEmailDocumentsDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



      
    }
}
