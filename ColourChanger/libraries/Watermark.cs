﻿using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class Watermark
    {


        public static Bitmap AddVisibleWatermark(Bitmap myBitmap, Bitmap myWatermark, double myOpacity)
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

            int ww = myWatermark.Width;
            int wh = myWatermark.Height;

            if (w < ww || h < wh)
            {
                // myWatermark = myWatermark.ScaleImage(w, h);
                ww = myWatermark.Width;
                wh = myWatermark.Height;
            }

            BitmapData wmark_data = myWatermark.LockBits(
                new Rectangle(0, 0, ww, wh),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int wbytes = wmark_data.Stride * wmark_data.Height;
            byte[] wbuffer = new byte[wbytes];
            Marshal.Copy(wmark_data.Scan0, wbuffer, 0, wbytes);
            myWatermark.UnlockBits(wmark_data);

            result = buffer;

            for (int i = 0; i < ww; i++)
            {
                for (int j = 0; j < wh; j++)
                {
                    int wposition = i * 3 + j * wmark_data.Stride;
                    int position = i * 3 + j * image_data.Stride;
                    for (int k = 0; k < 3; k++)
                    {
                        result[position + k] = (byte)((1 - myOpacity) * result[position + k] + myOpacity * wbuffer[wposition + k]);
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



        public static Bitmap AddInvisibleWatermark(Bitmap myBitmap, Bitmap myWatermark)
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

            int ww = myWatermark.Width;
            int wh = myWatermark.Height;

            if (w < ww || h < wh)
            {
              //  myWatermark = myWatermark.ScaleImage(w, h);
                ww = myWatermark.Width;
                wh = myWatermark.Height;
            }

            BitmapData wmark_data = myWatermark.LockBits(
                new Rectangle(0, 0, ww, wh),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int wbytes = wmark_data.Stride * wmark_data.Height;
            byte[] wbuffer = new byte[wbytes];

            Marshal.Copy(wmark_data.Scan0, wbuffer, 0, wbytes);
            myWatermark.UnlockBits(wmark_data);

            result = buffer;
            for (int i = 0; i < ww; i++)
            {
                for (int j = 0; j < wh; j++)
                {
                    int wposition = i * 3 + j * wmark_data.Stride;
                    int position = i * 3 + j * image_data.Stride;
                    for (int k = 0; k < 3; k++)
                    {
                        result[position + k] = (byte)((4 * result[position + k]) / 4 + wbuffer[wposition + k] / 64);
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


        // Copy the watermark image over the result image.
        public static Bitmap DrawWatermark(Bitmap myWatermarkBitmap, Bitmap myBitmap, int x, int y)
        {
            //Initialise the bitmap we will return
            Bitmap resultBitmap = myBitmap;

            // Make a ColorMatrix that multiplies
            // the alpha component by 0.5.
            ColorMatrix color_matrix = new ColorMatrix();
            color_matrix.Matrix33 = 0.5f;

            // Make an ImageAttributes that uses the ColorMatrix.
            ImageAttributes image_attributes = new ImageAttributes();
            image_attributes.SetColorMatrices(color_matrix, null);

            // Make pixels that are the same color as the
            // one in the upper left transparent.
            myWatermarkBitmap.MakeTransparent(myWatermarkBitmap.GetPixel(0, 0));

            // Draw the image using the ColorMatrix.
            using (Graphics gr = Graphics.FromImage(myBitmap))
            {
                Rectangle rect = new Rectangle(x, y, myWatermarkBitmap.Width, myWatermarkBitmap.Height);

                gr.DrawImage(myWatermarkBitmap, rect, 0, 0, myWatermarkBitmap.Width, myWatermarkBitmap.Height,
                    GraphicsUnit.Pixel, image_attributes);

                resultBitmap = new Bitmap(myBitmap.Width, myBitmap.Height,  gr);
            }

            return resultBitmap;
        }
    }
}
