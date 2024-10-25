using System.Drawing;
using System.Windows.Forms;

namespace ColourChanger.utils
{
    class ColouringUtils
    {

        // swap one color with another
       
        public Bitmap ChangeColor(Bitmap scrBitmap, Color newColor)
        {
            Color actualColor;

            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    actualColor = scrBitmap.GetPixel(i, j);
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }

       
        public static string[] ChooseColor()
        {
            string[] myData = new string[4];

            ColorDialog myColorDialog = new ColorDialog();

            if (myColorDialog.ShowDialog() == DialogResult.OK)
            {
                myData[0] = (myColorDialog.Color.R / 255f).ToString("f4");
                myData[1] = (myColorDialog.Color.G / 255f).ToString("f4");
                myData[2] = (myColorDialog.Color.B / 255f).ToString("f4");
                myData[3] = (myColorDialog.Color.A / 255f).ToString("f4");
            }

            return myData;
        }
    }
}
