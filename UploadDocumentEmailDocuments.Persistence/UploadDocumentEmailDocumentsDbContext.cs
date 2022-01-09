using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain;
using UploadDocumentEmailDocuments.Domain.Common;

namespace UploadDocumentEmailDocuments.Persistence
{
   public class UploadDocumentEmailDocumentsDbContext : DbContext
    {
        public UploadDocumentEmailDocumentsDbContext(DbContextOptions<UploadDocumentEmailDocumentsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UploadDocumentEmailDocumentsDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.DateLastModified = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<UsersPersonalDetail> UsersPersonalDetail { get; set; }
        public DbSet<FilesDetail> FilesDetails { get; set; }
       
    }
   
}
