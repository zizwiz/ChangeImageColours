using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class ColourBalance
    {


        public static Bitmap AdjustCyan(Bitmap myBitmap, double AdjustCyanBy)
        {
            int w = myBitmap.Width;
            int h = myBitmap.Height;
            BitmapData image_data = myBitmap.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
           
            byte[] buffer = new byte[bytes+2]; //Changed to bytes + 2. If not then is below is out of range
            byte[] result = new byte[bytes+2]; //Changed to bytes + 2. If not then is below is out of range

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            myBitmap.UnlockBits(image_data);
            for (int i = 0; i < bytes; i += 3)
            {
                //convert from RGB to CMY - sequence of stored pixel values is BGR
                //so we pick every third number for red color channel
                double normalized = (double)buffer[i+2] / 255;
                double cyan = Math.Pow(1d - normalized, AdjustCyanBy);
                result[i+2] = (byte)((1d - cyan) * 255);
                
                for (int j = 0; j < 2; j++)
                {
                    result[i + j] = buffer[i + j];
                }
            }
            Bitmap res_img = new Bitmap(w, h);
            BitmapData res_data = res_img.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, res_data.Scan0, bytes);
            res_img.UnlockBits(res_data);
            return res_img;
        }







    }
}
