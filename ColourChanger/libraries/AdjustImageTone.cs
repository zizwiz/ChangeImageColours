using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class AdjustImageTone
    {
        //Before applying any colour corrections to our bitmap,
        //we first need to adjust its tonal range to fix the general
        //distribution of colour intensities.


        /// <summary>
        /// We have to darken first half of intensities and brighten the other.
        /// In order to do that we will apply two different gamma correction
        /// transformations for the whole image. 
        /// </summary>
        /// <param name="myBitmap"></param>
        /// <returns>Bitmap</returns>
        public static Bitmap FlatCorrection(Bitmap myBitmap, double AdjustBy)
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

            //If the variable is 0 to 1, we will end up with a lighter image and if it’s above 1 we will darken it.
            // double y = AdjustBy; //2

            for (int i = 0; i < bytes; i++)
            {
                if (buffer[i] < 128)
                {
                    double normalized = (double)buffer[i] / 128;
                    //result[i] = (byte)(Math.Pow(normalized, y) * 128);
                    result[i] = (byte)(Math.Pow(normalized, AdjustBy) * 128);
                }
                else
                {
                    double normalized = ((double)buffer[i] - 128) / 128;
                    //result[i] = (byte)((Math.Pow(normalized, 1 / y) * 128) + 128);
                    result[i] = (byte)((Math.Pow(normalized, 1 / AdjustBy) * 128) + 128);
                }
            }
            Bitmap res_img = new Bitmap(w, h);
           
            BitmapData res_data = res_img.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
           
            Marshal.Copy(result, 0, res_data.Scan0, bytes);
           
            res_img.UnlockBits(res_data);
           // return res_img;


            return LightCorrection(res_img, AdjustBy); //get bitmap back from LightCorrection
        }

        /// <summary>
        /// Lighten or Darken Image
        /// </summary>
        /// <param name="myBitmap"></param>
        /// <param name="AdjustBy"></param>
        /// <returns></returns>
        public static Bitmap LightCorrection(Bitmap myBitmap, double AdjustBy)
        {
            int w = myBitmap.Width;
            int h = myBitmap.Height;

            //If the variable is 0 to 1, we will end up with a lighter image and if it’s above 1 we will darken it.
            //double y = 2; 

            BitmapData image_data = myBitmap.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            myBitmap.UnlockBits(image_data);
            
            
           
            for (int i = 0; i < bytes; i++)
            {
                double normalized = (double)buffer[i] / 255;
                //result[i] = (byte)(Math.Pow(normalized,y) * 255);
                result[i] = (byte)(Math.Pow(normalized, AdjustBy) * 255);
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
