using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Common
{
    public class ImageUploader
    {
        public static string ImageChangeName(string imageName)
        {
            //1=> Uymayan format

            string newFileName = "";

            var uniqueName = Guid.NewGuid().ToString();

            var fileArray = imageName.Split('.');

            var extension = fileArray[fileArray.Length - 1];

            if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "gif" || extension == "svg" || extension == "bmp" || extension == "webp")
            {
                newFileName = uniqueName + "." + extension;

                return newFileName;
            }
            else
            {
                return "1";
            };
        }
    }
}
