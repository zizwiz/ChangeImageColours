using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class Enhance
    {
        public static Bitmap EnhanceBitmap(Bitmap image, int byHowMuch)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            int o = (byHowMuch - 1) / 2;
            for (int i = o; i < w - o; i++)
            {
                for (int j = o; j < h - o; j++)
                {
                    int position = i * 3 + j * image_data.Stride;
                    for (int k = -o; k <= o; k++)
                    {
                        for (int l = -o; l <= o; l++)
                        {
                            int se_pos = position + k * 3 + l * image_data.Stride;
                            for (int c = 0; c < 3; c++)
                            {
                                result[se_pos + c] = Math.Max(result[se_pos + c], buffer[position]);
                            }
                        }
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
