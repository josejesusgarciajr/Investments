using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Investments.Models
{
    public class FolderAndDirectories
    {
        /*
         * Microsoft.AspNetCore.Hosting.IWebHostEnvironment
         */
        public IWebHostEnvironment webHostEnvironment { get; set; }

        public FolderAndDirectories()
        {
        }

        public FolderAndDirectories(IWebHostEnvironment e)
        {
            webHostEnvironment = e;
        }

        public string PutImageTo(IFormFile image, string dir)
        {
            string directory = webHostEnvironment.WebRootPath + "/" + dir;
            string destinationFile = directory + "/" + image.FileName;
            Console.WriteLine($"Directory: {directory}");
            Console.WriteLine($"DestinationFile: {destinationFile}");

            if (Directory.Exists(directory))
            {
                image.CopyTo(new FileStream(destinationFile, FileMode.Create));
            } else
            {
                // create directory first, then put image
                Directory.CreateDirectory(directory);
                image.CopyTo(new FileStream(destinationFile, FileMode.Create));
            }

            return $"/{dir}/" + image.FileName;

        }

    }
}
