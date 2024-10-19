using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class Erosion
    {

        public static Bitmap ErodeBitmap(Bitmap myBitmap, int byHowMuch)
        {
            int w = myBitmap.Width;
            int h = myBitmap.Height;

            BitmapData image_data = myBitmap.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
           
            myBitmap.UnlockBits(image_data);

            int o = (byHowMuch - 1) / 2;

            for (int i = o; i < w - o; i++)
            {
                for (int j = o; j < h - o; j++)
                {
                    int position = i * 3 + j * image_data.Stride;
                    byte val = 255;
                    for (int x = -o; x <= o; x++)
                    {
                        for (int y = -o; y <= o; y++)
                        {
                            int kposition = position + x * 3 + y * image_data.Stride;
                            val = Math.Min(val, buffer[kposition]);
                        }
                    }
                    for (int c = 0; c < 3; c++)
                    {
                        result[position + c] = val;
                    }
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
