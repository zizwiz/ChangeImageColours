using System;
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
        }

        private void btn_open_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picbx_Original.Image = LoadBitmapUnlocked(openFileDialog.FileName);

                string myFileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                ApplyFilterToImage();
            }

        }

        
    }
}
