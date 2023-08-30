using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ASMC5.Models;
using System;
using System.IO;

namespace ASMC5.Services
{
    public class UpLoadSvc
    {
        public static string UploadFile(IFormFile ImageFile, IWebHostEnvironment webHostEnvironment)
        {
            string uniqueFileName = null;
            if (ImageFile != null && ImageFile.Length>0)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
