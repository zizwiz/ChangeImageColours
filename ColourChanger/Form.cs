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
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            if (!File.Exists("ColourFilterData.xml"))
                File.WriteAllText("ColourFilterData.xml", Properties.Resources.ColourFilterData);

            //Start thread to populate the colour filter combobox
            //Watch cross threading
            Thread myThread;
            myThread = new Thread(PopulateAirfieldCmboBx);
            myThread.Start();



            //Get the data file from resources and write to file in same dir as the app.
            //File.WriteAllText("airport_data.xml", Properties.Resources.airport_data);

            dgv_ColourFiltersData.Rows.Add();
            dgv_ColourFiltersData.Rows.Add();
            dgv_ColourFiltersData.Rows.Add();
            dgv_ColourFiltersData.Rows.Add();
            dgv_ColourFiltersData.Rows.Add();


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
    }
}
