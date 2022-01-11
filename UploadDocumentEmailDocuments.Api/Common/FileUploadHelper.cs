using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace UploadDocumentEmailDocuments.Api.Common
{
    public static class FileUploadHelper
    {
        //Upload Files
        public static List<string> MultipleFileUpload(IFormFile[] files)
        {
            List<string> items = new List<string>();
            foreach (var item in files)
            {
                //Assigning Unique Filename (Guid)
                var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                //Getting file Extension
                var fileExtension = Path.GetExtension(item.FileName);
                // concatenating  FileName + FileExtension
                var newFileName = String.Concat(myUniqueFileName, fileExtension);
                var filePath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "documents")).Root + $@"\{newFileName}";

                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    item.CopyTo(fs);
                    fs.Flush();
                }
                items.Add(myUniqueFileName);
            }
            return items;
        }

        //Download Files
        public static (string fileType, byte[] archiveData, string archiveName) DownloadFiles()
        {
            var zipName = $"archive-{DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss")}.zip";

            
            var files = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "documents")).ToList();

            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach(string file in files)
                    {
                        var theFile = archive.CreateEntry(file);
                        using (var streamWriter = new StreamWriter(theFile.Open()))
                        {
                            streamWriter.Write(File.ReadAllText(file));
                        }

                    }
                   
                }

                return ("application/zip", memoryStream.ToArray(), zipName);
            }

        }

       

    }
}
