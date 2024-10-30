using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ColourChanger.history;
using ColourChanger.libraries;
using ColourChanger.utils;
using help_about;



namespace ColourChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put version number into topbar

            // Add 5 rows to dataGridView
            for (int x = 0; x < 5; x++)
            {
                dgv_ColourFiltersData.Rows.Add();
            }

            //Add headers to rows
            dgv_ColourFiltersData.Rows[0].HeaderCell.Value = "Red Scaling Factor";
            dgv_ColourFiltersData.Rows[1].HeaderCell.Value = "Green Scaling Factor";
            dgv_ColourFiltersData.Rows[2].HeaderCell.Value = "Blue Scaling Factor";
            dgv_ColourFiltersData.Rows[3].HeaderCell.Value = "Alpha Scaling Factor";
            dgv_ColourFiltersData.Rows[4].HeaderCell.Value = "Brightness Scaling Factor";
            

            // Resize the row headers
            dgv_ColourFiltersData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders; 
            
            //if the xml file is not present then create it from the template one in resources 
            if (!File.Exists("ColourFilterData.xml"))
                File.WriteAllText("ColourFilterData.xml", Properties.Resources.ColourFilterData);

            //Start thread to populate the colour filter combobox
            //Watch cross threading
            Thread myThread = new Thread(() => PopulateColourFiltersCmboBx("Reset"));
            myThread.Start();

            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help_Form help = new Help_Form();
            help.Show();
        }

        // Write data to dataGridView based on the filter chosen in the combobox.
        private void cmbobx_ColourFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateColourFiltersDataGridView(cmbobx_ColourFilters.Text);
            trkbar_brightness.Value = 0;
            trkbar_contrast.Value = 100;

            if (cmbobx_ColourFilters.Text == "Choose the filter colour to use")
            {
                //let the user choose the filter colour
                string[] myColourData = ColouringUtils.ChooseColor();
                dgv_ColourFiltersData[0, 0].Value = myColourData[0];
                dgv_ColourFiltersData[1, 1].Value = myColourData[1];
                dgv_ColourFiltersData[2, 2].Value = myColourData[2];
                dgv_ColourFiltersData[3, 3].Value = myColourData[3];
            }
            ApplyFilterToImage(0);
        }

        private void btn_open_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageFileDialog = new OpenFileDialog();
            openImageFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Exif Image|*.exif|" +
                                         "Png Image|*.png|Tiff Image| *.tiff"; 
            openImageFileDialog.FilterIndex = 1;
            openImageFileDialog.Title = "Open Image File";


            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (picbx_Original.Image != null) //if already an image present then clear it and collect garbage
                {
                    picbx_Original.Image = null;
                    picbx_result.Image = null;
                    GC.Collect();
                }

                //open the new image
                picbx_Original.Image = LoadBitmapUnlocked(openImageFileDialog.FileName);

                string myFileName = Path.GetFileNameWithoutExtension(openImageFileDialog.FileName);

                ApplyFilterToImage(0);
            }

        }

        private void btn_apply_filter_Click(object sender, EventArgs e)
        {
            ApplyFilterToImage(0);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cmbobx_ColourFilters.Text = "Reset";
            PopulateColourFiltersDataGridView(cmbobx_ColourFilters.Text);
            trkbar_brightness.Value = 0;
            trkbar_contrast.Value = 100;
            ApplyFilterToImage(1);
        }

        private void trkbar_brightness_Scroll(object sender, EventArgs e)
        {
            GC.Collect();
            float brightnessValue = (float) (trkbar_brightness.Value) / 100;
            dgv_ColourFiltersData[4, 0].Value = brightnessValue;
            dgv_ColourFiltersData[4, 1].Value = brightnessValue;
            dgv_ColourFiltersData[4, 2].Value = brightnessValue;
            ApplyFilterToImage(0);
        }

        private void trkbar_contrast_Scroll(object sender, EventArgs e)
        {
            GC.Collect();
            float contrastValue = (float)(trkbar_contrast.Value) / 100;
            dgv_ColourFiltersData[0, 0].Value = contrastValue;
            dgv_ColourFiltersData[1, 1].Value = contrastValue;
            dgv_ColourFiltersData[2, 2].Value = contrastValue;
            ApplyFilterToImage(0);
        }

        private void btn_save_image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Exif Image|*.exif|" +
                                    "Png Image|*.png|Tiff Image| *.tiff";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Title = "Save an Image File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               Image  myImage = picbx_result.Image;
                string myFilename = saveFileDialog.FileName;


                string extension = Path.GetExtension(myFilename);

                // switch (extension.ToLower())
                switch (saveFileDialog.FilterIndex.ToString())
                {
                    case "2":
                        myImage.Save(myFilename, ImageFormat.Bmp);
                        break;
                    case "4":
                        myImage.Save(myFilename, ImageFormat.Exif);
                        break;
                    case "3":
                        myImage.Save(myFilename, ImageFormat.Gif);
                        break;
                    case "1":
                        myImage.Save(myFilename, ImageFormat.Jpeg);
                        break;
                    case "5":
                        myImage.Save(myFilename, ImageFormat.Png);
                        break;
                    case "6":
                         myImage.Save(myFilename, ImageFormat.Tiff);
                        break;
                    default:
                        throw new NotSupportedException(
                            "Unknown file extension " + extension);
                }
            }
        }

       
        private void btn_adjust_Click(object sender, EventArgs e)
        {
            // picbx_result.Image = ColourBalance.AdjustCyan((Bitmap)picbx_Original.Image, double.Parse(txtbx_adjust_value.Text));


            // picbx_result.Image = AdjustImageTone.FlatCorrection((Bitmap) picbx_Original.Image, double.Parse(txtbx_adjust_value.Text));



            //cmbobx_ColourFilters.Text = "Grey Scale";
            //picbx_result.Image = GreyscaleMorphology.MorphologicalSmoothing((Bitmap)picbx_result.Image);


            //  picbx_result.Image = FalseColour.Pseudocolourise((Bitmap) picbx_Original.Image); 

            //if (NumberUtils.isInteger(txtbx_adjust_value))
            //{
            //    picbx_result.Image =
            //        Erosion.ErodeBitmap((Bitmap) picbx_Original.Image, int.Parse(txtbx_adjust_value.Text));
            //}

            //enhance
            //if (NumberUtils.isInteger(txtbx_adjust_value))
            //{
            //    picbx_result.Image =
            //        Enhance.EnhanceBitmap((Bitmap)picbx_Original.Image, int.Parse(txtbx_adjust_value.Text));
            //}

            //watermark

            //picbx_result.Image = Watermark.AddVisibleWatermark((Bitmap)picbx_Original.Image, BitmapUtils.ConvertToBitmap("Watermark.jpg"),
            //    int.Parse(txtbx_adjust_value.Text));


            //picbx_result.Image = Watermark.AddInvisibleWatermark((Bitmap)picbx_Original.Image, BitmapUtils.ConvertToBitmap("Watermark.jpg"));

            //picbx_result.Image = Watermark.AddVisibleWatermark((Bitmap)picbx_Original.Image, BitmapUtils.ScaleWatermarkBitmap("watermark2.jpg", (Bitmap)picbx_Original.Image),
            //    int.Parse(txtbx_adjust_value.Text));

            //create a scaled watermark
            //BitmapUtils.ScaleWatermarkBitmap("watermark2.jpg", (Bitmap)picbx_Original.Image);

            // picbx_result.Image = null;

            //var x = (picbx_Original.Image.Width - BitmapUtils.ConvertToBitmap("Watermark2.jpg").Width) / 2;
            //var y = (picbx_Original.Image.Height - BitmapUtils.ConvertToBitmap("Watermark2.jpg").Height) / 2;

            //picbx_result.Image = Watermark.DrawWatermark(BitmapUtils.ScaleWatermarkBitmap("watermark2.jpg", (Bitmap)picbx_Original.Image), (Bitmap) picbx_Original.Image, x, y);
            //ApplyFilterToImage();

            //superimpose image
            //picbx_result.Image = null;
            //picbx_result.Image = BitmapUtils.Superimpose((Bitmap) picbx_Original.Image,
            //    BitmapUtils.ConvertToBitmap("Watermark2.jpg"));

            //ApplyFilterToImage();

           GC.Collect();
        }

        private void chkbx_save_history_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_save_history.Checked)
            {
                SaveFileDialog saveHistoryFileDialog = new SaveFileDialog();
                saveHistoryFileDialog.Filter = "cch File|*.cch"; // cch = colour changer history file, just a csv file.
                saveHistoryFileDialog.FilterIndex = 1;
                saveHistoryFileDialog.Title = "Save History";

                if (saveHistoryFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the filename from the tag
                    chkbx_save_history.Tag = saveHistoryFileDialog.FileName;

                    //make the file and write the headers to it 
                    SaveHistory.Save(chkbx_save_history, dgv_history);
                }
            }
        }

        private void btn_open_history_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openHistoryFileDialog = new OpenFileDialog();
            openHistoryFileDialog.Filter = "cch File|*.cch"; // cch = colour changer history file, just a csv file.
            openHistoryFileDialog.FilterIndex = 1;
            openHistoryFileDialog.Title = "Open History";

            if (openHistoryFileDialog.ShowDialog() == DialogResult.OK)
            {

                OpenHistory.PopulateHistoryDGV(openHistoryFileDialog.FileName, dgv_history, chkbx_save_history);


            }
        }


    }
}
