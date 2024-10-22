using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace ColourChanger.utils
{
    class BitmapUtils
    {
        public static Bitmap ConvertToBitmap(string myFileName)
        {
            return (Bitmap)Image.FromFile(myFileName);
            //return new Bitmap(Image.FromStream(File.Open(myFileName, FileMode.Open)));
        }

        public static Bitmap ScaleWatermarkBitmap(string myFileName, Bitmap myBitmap)
        {
            int ratio = 1;
            //We want the watermark to be at most 25% of the original bitmap.
            //int bitmapHeight = myBitmap.Height / 4;
            //int bitmapWidth = myBitmap.Width / 4;

            Bitmap watermarkBitmap = (Bitmap)Image.FromFile(myFileName);

            int DiffInHeight = myBitmap.Height - watermarkBitmap.Height;
            int DiffInWidth = myBitmap.Width - watermarkBitmap.Width;

            if (DiffInHeight >= DiffInWidth)
            {
                ratio = (myBitmap.Height / watermarkBitmap.Height) * 4;
            }
            else
            {
                ratio = (myBitmap.Width / watermarkBitmap.Width) * 4;
            }

            watermarkBitmap = new Bitmap(watermarkBitmap, new Size(watermarkBitmap.Width / ratio, watermarkBitmap.Height / ratio));

            //watermarkBitmap.Save("resized.bmp");

            return watermarkBitmap;


        }

        /// <summary>
        /// Scale Bitmap when you know the ratio you want, ratio as a percentage
        /// </summary>
        /// <param name="myFileName"></param>
        /// <param name="ratio"></param>
        /// <returns>Resized Bitmap</returns>
        public static Bitmap ScaleBitmap(string myFileName, int ratio)
        {
            Bitmap original = (Bitmap)Image.FromFile(myFileName);
            return new Bitmap(original, new Size(original.Width / (100 / ratio), original.Height / (100 / ratio)));
        }

        /// <summary>
        /// Scale Bitmap when you know the ratio you want, ratio as a percentage
        /// </summary>
        /// <param name="myBitmap"></param>
        /// <param name="ratio"></param>
        /// <returns>Resized Bitmap</returns>
        public static Bitmap ScaleBitmap(Bitmap myBitmap, int ratio)
        {
            return new Bitmap(myBitmap, new Size(myBitmap.Width / (100 / ratio), myBitmap.Height / (100 / ratio)));
        }

        /// <summary>
        /// Draw one bitmap over another.
        /// </summary>
        /// <param name="myParentBitmap"></param>
        /// <param name="myChildBitmap"></param>
        /// <returns>Superimposed Bitmap</returns>
        public static Bitmap Superimpose(Bitmap myParentBitmap, Bitmap myChildBitmap)
        {

            Graphics g = Graphics.FromImage(myParentBitmap);
            g.CompositingMode = CompositingMode.SourceOver;

            // Resize it so it fits
            myChildBitmap = ScaleBitmap(myChildBitmap, 25);

            //Make Transparent
            myChildBitmap.MakeTransparent(myChildBitmap.GetPixel(0, 0));

            var x = (myParentBitmap.Width - myChildBitmap.Width) / 2;
            var y = (myParentBitmap.Height - myChildBitmap.Height) / 2;

            g.DrawImage(myChildBitmap, new Point(x, y));

            return myParentBitmap;
        }

    }
}
