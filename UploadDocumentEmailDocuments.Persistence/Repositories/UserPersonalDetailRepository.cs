using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Persistence.Repositories
{
   
    public class UserPersonalDetailRepository : GenericRepository<UsersPersonalDetail>, IUserPersonalDetail
    {
        private readonly UploadDocumentEmailDocumentsDbContext _dbContext;

        public UserPersonalDetailRepository(UploadDocumentEmailDocumentsDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UsersPersonalDetail> GetUserPersonalByEmailAndReferenceNo(string email, string referenceNo)
        {
            var leaveAllocation = await _dbContext.UsersPersonalDetail
               .Include(q => q.fileDetails)
               .FirstOrDefaultAsync(q => q.Email == email && q.ReferenceNumber==referenceNo);

            return leaveAllocation;
        }

        public async Task<UsersPersonalDetail> GetUserPersonalDetailWithFiles(int id)
        {
            var leaveAllocation = await _dbContext.UsersPersonalDetail
               .Include(q => q.fileDetails)
               .FirstOrDefaultAsync(q => q.Id == id);

            return leaveAllocation;
        }

        public async Task<List<UsersPersonalDetail>> GetUserPersonalDetailWithFiles()
        {
            var leaveAllocations = await _dbContext.UsersPersonalDetail
               .Include(q => q.fileDetails)
               .ToListAsync();
            return leaveAllocations;
        }
    }
}
