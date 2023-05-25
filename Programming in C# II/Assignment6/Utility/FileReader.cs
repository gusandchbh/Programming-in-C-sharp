using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Utility
{
    public static class FileReader
    {
        public static List<string> ReadTextFile(string filePath)
        {
            try
            {
                // Check if file exists
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Could not find file!", filePath);
                }

                // Read file content
                List<string> fileContent = File.ReadLines(filePath, Encoding.UTF8).ToList();

                return fileContent;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Could not read file: {ex.Message}", ex);
            }
        }
    }
}
