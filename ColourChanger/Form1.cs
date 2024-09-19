using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using help_about;
using System.Xml;
using ColourChanger.data;
using ColourChanger.utils;


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

            //if the xml file is not present then create it from the template one in resources 
            if (!File.Exists("ColourFilterData.xml"))
                File.WriteAllText("ColourFilterData.xml", Properties.Resources.ColourFilterData);

            //Start thread to populate the colour filter combobox
            //Watch cross threading
            Thread myThread;
            myThread = new Thread(PopulateColourFiltersCmboBx);
            myThread.Start();

            // Add 5 rows to dataGridView
            for (int x = 0; x < 5; x++)
            {
                dgv_ColourFiltersData.Rows.Add();
            }


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

        // Write data to dataGridView.
        private void cmbobx_ColourFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterData.xml");
            XmlNode root = doc.DocumentElement;

            XmlNodeList ColourFilterList = root.SelectNodes("descendant::Data[name ='" + cmbobx_ColourFilters.Text + "']");

            foreach (XmlNode data in ColourFilterList)
            {
                //    dgv_ColourFiltersData[0, 0].Value =  data["RedByte_RedScalling"].InnerText;
                //    dgv_ColourFiltersData[1, 0].Value =  data["RedByte_GreenScalling"].InnerText;

                // We get the indexes of > and <
                var indexFrom = StringUtils.AllIndexesOf(data.InnerXml, ">").ToArray();
                var indexTo = StringUtils.AllIndexesOf(data.InnerXml, "<").ToArray();

                int from = 2;
                int to = 3;

                //write data to dataGridView
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        dgv_ColourFiltersData[x, y].Value = data.InnerXml.Substring(indexFrom[from] + 1, indexTo[to] - indexFrom[from] - 1);

                        from += 2;
                        to += 2;

                    }
                }
            }
        }
    }
}
