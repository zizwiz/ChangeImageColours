using System.IO;

namespace ColourChanger.utils
{
    class FileUtils
    {
        public static int NumberOfLinesInFile(string myFileName)
        {
            if (!File.Exists(myFileName))
            {
                throw new FileNotFoundException($"File not found: {myFileName}");
            }
           
            return File.ReadAllLines(myFileName).Length;
        }
    }
}
