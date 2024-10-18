using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class FalseColour
    {
        public static Bitmap Pseudocolourise(Bitmap myBitmap)
        {
            int w = myBitmap.Width;
            int h = myBitmap.Height;
          
            BitmapData image_data = myBitmap.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            
            int bytes = image_data.Stride * image_data.Height;
            
            byte[] buffer = new byte[bytes];
            
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            
            myBitmap.UnlockBits(image_data);

            byte[] unique = buffer.Distinct().ToArray();
            Array.Sort(unique);

            int blue = 255;
            int green = 0;
            int red = 0;

            byte[][] color_scale = new byte[unique.Length][];

            for (int i = 0; i < unique.Length; i++)
            {
                color_scale[i] = new byte[3];
                byte step = (byte)Math.Round(512f / unique.Length);

                if (blue > 0 && green < 255)
                {
                    color_scale[i][0] = (byte)blue;
                    color_scale[i][1] = (byte)green;
                    color_scale[i][2] = 0;

                    blue -= step;
                    green += step;

                    if (blue < 0)
                    {
                        blue = 0;
                    }

                    if (green > 255)
                    {
                        green = 255;
                    }
                }

                else
                {
                    color_scale[i][0] = 0;
                    color_scale[i][1] = (byte)green;
                    color_scale[i][2] = (byte)red;

                    green -= step;
                    red += step;

                    if (green < 0)
                    {
                        green = 0;
                    }

                    if (red > 255)
                    {
                        red = 255;
                    }
                }
            }

            byte[] result = new byte[bytes];
            
            for (int i = 0; i < bytes; i += 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i + j] = color_scale[Array.IndexOf(unique, buffer[i + j])] [j];
                }
            }
           
            Bitmap result_image = new Bitmap(w, h);
            
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            
            result_image.UnlockBits(result_data);
            
            return result_image;
        }


    }
}
