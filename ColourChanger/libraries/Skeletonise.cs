using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;

namespace ColourChanger.libraries
{
    class Skeletonise
    {
        /*

        public static Bitmap MakeSkeleton(Bitmap myBitmap)
        {
            int w = myBitmap.Width;
            int h = myBitmap.Height;

            BitmapData image_data = myBitmap.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format8bppIndexed);

            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] temp = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            myBitmap.UnlockBits(image_data);

            while (true)
            {
                temp = buffer.Erode(w, h);
                int sum = temp.Sum(x => (int)x);

                if (sum == 0)
                {
                    break;
                }

                temp = temp.Dilate(w, h);

                for (int i = 0; i < bytes; i++)
                {
                    result[i] += (byte)(buffer[i] - temp[i]);
                }

                buffer = buffer.Erode(w, h);
            }

            Bitmap res_img = new Bitmap(w, h);
            BitmapData res_data = res_img.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format8bppIndexed);
            Marshal.Copy(result, 0, res_data.Scan0, bytes);
            res_img.UnlockBits(res_data);
            return res_img;
        }*/
    }
}
