using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UploadDocumentEmailDocuments.Application.DTOs.UserPersonalDetail
{
    public class CreateUserPersonalDetailDTO: IUserPersonalDetailDTO 
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public List<IFormFile> Files { get; set; }
    }
    
}
