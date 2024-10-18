using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class GreyscaleMorphology
    {

        public static byte[] Erode(byte[] buffer, BitmapData myBitmapData)
        {
            byte[] result = new byte[buffer.Length];

            for (int x = 1; x < myBitmapData.Width - 1; x++)
            {
                for (int y = 1; y < myBitmapData.Height - 1; y++)
                {
                    int position = x * 3 + y * myBitmapData.Stride;
                    byte val = 255;
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            int se_pos = position + i * 3 + j * myBitmapData.Stride;
                            val = Math.Min(val, buffer[se_pos]);
                        }
                    }
                    for (int c = 0; c < 3; c++)
                    {
                        result[position + c] = val;
                    }
                }
            }

            return result;
        }

        public static byte[] Dilate(byte[] buffer, BitmapData myBitmapData)
        {
            byte[] result = new byte[buffer.Length];
            for (int x = 1; x < myBitmapData.Width - 1; x++)
            {
                for (int y = 1; y < myBitmapData.Height - 1; y++)
                {
                    int position = x * 3 + y * myBitmapData.Stride;
                    byte val = 0;
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            int se_pos = position + i * 3 + j * myBitmapData.Stride;
                            val = Math.Max(val, buffer[se_pos]);
                        }
                    }
                    for (int c = 0; c < 3; c++)
                    {
                        result[position + c] = val;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Remove noise and smooth greyscale images.
        /// </summary>
        /// <param name="myBitmap"></param>
        /// <returns>Bitmap</returns>
        public static Bitmap MorphologicalSmoothing(Bitmap myBitmap)
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

            //opening
            result = Erode(buffer, image_data);
            result = Dilate(result, image_data);

            //closing
            result = Dilate(result, image_data);
            result = Erode(result, image_data);

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
