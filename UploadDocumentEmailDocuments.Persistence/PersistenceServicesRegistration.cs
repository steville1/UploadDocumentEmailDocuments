using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Application.Contracts.Persistence;
using UploadDocumentEmailDocuments.Persistence.Repositories;

namespace UploadDocumentEmailDocuments.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UploadDocumentEmailDocumentsDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DocumentUploadConnectionString")));


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUserPersonalDetail, UserPersonalDetailRepository>();
            services.AddScoped<IFileDetail, FileDetailRepository>();
           

            return services;
        }
    }
}
