using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGCollector
{
    public static class Functions
    {
        // Recursively move and rename JPG files in the specified folder and its subdirectories
        public static void MoveAndRenameJpgFiles(string sourceFolder, string destinationFolder)
        {
            if (Directory.Exists(sourceFolder))
            {
                // Get all JPG files in the current folder
                string[] jpgFiles = Directory.GetFiles(sourceFolder, "*.jpg");

                foreach (string jpgFile in jpgFiles)
                {
                    DateTime fileCreationTime = File.GetCreationTime(jpgFile);
                    string sourceFolderName = Path.GetFileName(sourceFolder);
                    string newFileName = Path.Combine(destinationFolder, $"{fileCreationTime:yyyyMMddHHmmss}_{sourceFolderName}_file.jpg");

                    // Check if the file already exists in the destination folder
                    if (!File.Exists(newFileName))
                    {
                        // Copy and rename the file
                        File.Copy(jpgFile, newFileName);
                    }
                }

                // Recursively move and rename JPG files in subdirectories
                string[] subdirectories = Directory.GetDirectories(sourceFolder);
                foreach (string subdirectory in subdirectories)
                {
                    MoveAndRenameJpgFiles(subdirectory, destinationFolder);
                }
            }
        }
    }


}
