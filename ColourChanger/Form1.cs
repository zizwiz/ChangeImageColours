using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
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

        // Write data to dataGridView based on the filter choosen in the combobox.
        private void cmbobx_ColourFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateColourFiltersDataGridView(cmbobx_ColourFilters.Text);
            trkbar_brightness.Value = 0;
            trkbar_contrast.Value = 100;
            ApplyFilterToImage();
        }

        private void btn_open_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (picbx_Original.Image != null) //if already an image present then clear it and collect garbage
                {
                    picbx_Original.Image = null;
                    picbx_result.Image = null;
                    GC.Collect();
                }

                //open the new image
                picbx_Original.Image = LoadBitmapUnlocked(openFileDialog.FileName);

                string myFileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                ApplyFilterToImage();
            }

        }

        private void btn_apply_filter_Click(object sender, EventArgs e)
        {
            ApplyFilterToImage();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            PopulateColourFiltersDataGridView(cmbobx_ColourFilters.Text);
            trkbar_brightness.Value = 0;
            trkbar_contrast.Value = 100;
            ApplyFilterToImage();
        }

        private void trkbar_brightness_Scroll(object sender, EventArgs e)
        {
            GC.Collect();
            float brightnessValue = (float) (trkbar_brightness.Value) / 100;
            dgv_ColourFiltersData[4, 0].Value = brightnessValue;
            dgv_ColourFiltersData[4, 1].Value = brightnessValue;
            dgv_ColourFiltersData[4, 2].Value = brightnessValue;
            ApplyFilterToImage();
        }

        private void trkbar_contrast_Scroll(object sender, EventArgs e)
        {
            GC.Collect();
            float contrastValue = (float)(trkbar_contrast.Value) / 100;
            dgv_ColourFiltersData[0, 0].Value = contrastValue;
            dgv_ColourFiltersData[1, 1].Value = contrastValue;
            dgv_ColourFiltersData[2, 2].Value = contrastValue;
            ApplyFilterToImage();
        }

        
    }
}
