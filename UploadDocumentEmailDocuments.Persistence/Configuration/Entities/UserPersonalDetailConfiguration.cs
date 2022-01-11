using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadDocumentEmailDocuments.Domain;

namespace UploadDocumentEmailDocuments.Persistence.Configuration.Entities
{
	//class UserPersonalDetailConfiguration
	public class LeaveTypeConfiguration : IEntityTypeConfiguration<UsersPersonalDetail>
	{
		public void Configure(EntityTypeBuilder<UsersPersonalDetail> builder)
		{
			builder.HasData(
			new UsersPersonalDetail
			{
				Id = 1,
				Name = "Stephen",
				Email ="steville2013@gmail.com",
				Phone ="08077670500",
				Age = "20"

			}
			
		);
	}




	}
}
