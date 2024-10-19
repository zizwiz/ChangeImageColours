using System.Drawing;
using System.IO;

namespace ColourChanger.utils
{
    class BitmapUtils
    {
        public static Bitmap ConvertToBitmap(string myFileName)
        {
           return new Bitmap(Image.FromStream(File.Open(myFileName, FileMode.Open)));
        }

    }
}
