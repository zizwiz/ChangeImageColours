using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using CenteredMessagebox;

namespace ColourChanger
{
    public partial class Form1
    {

        // Load a bitmap without locking it.
        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }

        // Apply filter to the image.
        private void ApplyFilterToImage(int myChoice)
        {
            if (picbx_Original.Image == null)
            {
                MsgBox.Show("No image found to work with, please open an image.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //If no image do nothing
            }

            if (myChoice == 1) chkbx_reset.Checked = true; // reset button pressed


            if (chkbx_reset.Checked)
            {
                picbx_result.Invalidate();
                picbx_result.Image = AdjustColor(picbx_Original.Image); // Each change on original each time
            }
            else
            {
                picbx_result.Image = AdjustColor(picbx_result.Image); //Superimpose each change on last change
            }


            //mnuFileSaveAs.Enabled = (picbx_result.Image != null);
        }

        // Adjust the image's colors.
        private Image AdjustColor(Image image)
        {
            // Make the ColorMatrix.
            ColorMatrix cm = GetColorMatrix();
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Make the result image.
            return CopyImage(image, attributes);
        }

        // Return the matrix entered by the user.
        private ColorMatrix GetColorMatrix()
        {
            float[][] values = GetMatrix();
            if (values == null) return null;
            return new ColorMatrix(values);
        }

        public static Image CopyImage(Image image, ImageAttributes attributes)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(result))
            {
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                gr.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return result;
        }


        private float[][] GetMatrix()
        {
            float[][] values = { new float[5], new float[5], new float[5], new float[5], new float[5], };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    float value;
                    if (!float.TryParse(dgv_ColourFiltersData[i,j].Value.ToString(), out value))
                    {
                        MessageBox.Show("Invalid entry");
                        //focus on invalid cell
                        dgv_ColourFiltersData.CurrentCell = dgv_ColourFiltersData.Rows[i].Cells[j];
                        return null;
                    }

                    values[i][j] = value;
                }
            }

            return values;
        }
    }


}
