using System;
using System.Windows.Forms;
using System.Xml;
using CenteredMessagebox;
using ColourChanger.data;
using ColourChanger.utils;
using System.Xml.Linq;
using System.Linq;
using System.Threading;

namespace ColourChanger
{
    public partial class Form1
    {
        void PopulateColourFiltersCmboBx(string FilterToSelect)
        {
            // A different thread watch cross threading
            //populate the combo boxes with the airfield names direct from xml file so we get 
            //names correctly spelt for later look up

            string filter = "Reset";

            //Make sure Combobox is clear
            //use invoke to prevent cross threading
            BeginInvoke(new Action(() =>
            {
                cmbobx_ColourFilters.Items.Clear();
            }));

            //Get the xmlfile
            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterData.xml");
            XmlNodeList ColourFilterList = doc.SelectNodes("ColourFilter/Data/name");

            foreach (XmlNode Name in ColourFilterList)
            {
                // data is content of each name
                string[] data = ColourFilterData.GetColourFilterData(Name.InnerText);
                
                //use invoke to prevent cross threading
                BeginInvoke(new Action(() =>
                {
                    cmbobx_ColourFilters.Items.Add(Name.InnerText);
                }));

                filter = Name.InnerText;
            }

            if (FilterToSelect == "Reset") filter = "Reset";

            //use invoke to prevent cross threading
            //Set to "Reset" filter
            BeginInvoke(new Action(() =>
            {
                cmbobx_ColourFilters.SelectedItem = filter;
            }));
        }

        void PopulateColourFiltersDataGridView(string myFilterName)
        {

            lbl_filter_name.Text = "Active filter = " + myFilterName;

            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterData.xml");
            XmlNode root = doc.DocumentElement;

            XmlNodeList ColourFilterList = root.SelectNodes("descendant::Data[name ='" + myFilterName + "']");

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

        /// <summary>
        /// Creating a New Filter and adding it to the XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_new_filter_Click(object sender, EventArgs e)
        {
            string myFilterName; 

            if (btn_new_filter.Text == "Create New Filter") //If it is add then we ask for a name
            {
                //create a dialog and get the name entered on it
                var filterNameForm = new FilterName();
                filterNameForm.ShowDialog();
                myFilterName = filterNameForm.myFilterName;

                btn_delete_filter.Visible = false;
                btn_update_filter.Visible = false;
                
                // Check if the name already exists. If it does let user know and do nothing
                //If name does not exist then we can do some work to add it.

                if (myFilterName == "error")
                {
                    return; //Something wrong so do nothing
                }

                if (CheckIfFilterNamExists(myFilterName))
                {
                    MsgBox.Show("Cannot add as named filter already exists\rChoose filter and use update",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_delete_filter.Visible = true;
                    btn_update_filter.Visible = true;
                    return;
                }

                lbl_filter_name.Text = myFilterName;


                GC.Collect();
                btn_new_filter.Text = "Save";
            }
            else if (btn_new_filter.Text == "Save")// if it is save then we save the new aircraft and its information
            {
                SaveData(lbl_filter_name.Text);
                btn_new_filter.Text = "Create New Filter";
                btn_delete_filter.Visible = true;
                btn_update_filter.Visible = true;

                //repopulate the combo box.
                //Start thread to populate the colour filter combobox
                //Watch cross threading
                Thread myThread = new Thread( () => PopulateColourFiltersCmboBx(lbl_filter_name.Text));
                myThread.Start();
            }
        }

        private bool CheckIfFilterNamExists(string myFilterName)
        {
            bool result = true;

            XDocument doc = XDocument.Load("ColourFilterdata.xml");

            var matches = doc
                .Descendants("Data")
                .Where(ft => ((string)ft.Element("name")) == myFilterName);

            if (matches.Count() == 0)
            {
                result = false;
            }

            return result;
        }

        private void SaveData(string myFilterName)
        {
            AddData(myFilterName);

            cmbobx_ColourFilters.SelectedIndex = cmbobx_ColourFilters.Items.Count - 1;
        }

        private void AddData(string myFilterName)
        {
            XDocument doc = XDocument.Load("ColourFilterdata.xml");
            XElement root = new XElement("Data");

            root.Add(new XElement("name", myFilterName));
            root.Add(new XElement("RedByte_RedScalling", dgv_ColourFiltersData[0, 0].Value));
            root.Add(new XElement("RedByte_GreenScalling", dgv_ColourFiltersData[1, 0].Value));
            root.Add(new XElement("RedByte_BlueScalling", dgv_ColourFiltersData[2, 0].Value));
            root.Add(new XElement("RedByte_AlphaScalling", dgv_ColourFiltersData[3, 0].Value));
            root.Add(new XElement("RedByte_ColourCast", dgv_ColourFiltersData[4, 0].Value));

            root.Add(new XElement("GreenByte_RedScalling", dgv_ColourFiltersData[0, 1].Value));
            root.Add(new XElement("GreenByte_GreenScalling", dgv_ColourFiltersData[1, 1].Value));
            root.Add(new XElement("GreenByte_BlueScalling", dgv_ColourFiltersData[2, 1].Value));
            root.Add(new XElement("GreenByte_AlphaScalling", dgv_ColourFiltersData[3, 1].Value));
            root.Add(new XElement("GreenByte_ColourCast", dgv_ColourFiltersData[4, 1].Value));

            root.Add(new XElement("BlueByte_RedScalling", dgv_ColourFiltersData[0, 2].Value));
            root.Add(new XElement("BlueByte_GreenScalling", dgv_ColourFiltersData[1, 2].Value));
            root.Add(new XElement("BlueByte_BlueScalling", dgv_ColourFiltersData[2, 2].Value));
            root.Add(new XElement("BlueByte_AlphaScalling", dgv_ColourFiltersData[3, 2].Value));
            root.Add(new XElement("BlueByte_ColourCast", dgv_ColourFiltersData[4, 2].Value));

            root.Add(new XElement("AlphaByte_RedScalling", dgv_ColourFiltersData[0, 3].Value));
            root.Add(new XElement("AlphaByte_GreenScalling", dgv_ColourFiltersData[1, 3].Value));
            root.Add(new XElement("AlphaByte_BlueScalling", dgv_ColourFiltersData[2, 3].Value));
            root.Add(new XElement("AlphaByte_AlphaScalling", dgv_ColourFiltersData[3, 3].Value));
            root.Add(new XElement("AlphaByte_ColourCast", dgv_ColourFiltersData[4, 3].Value));

            root.Add(new XElement("NotUsed_RedScalling", dgv_ColourFiltersData[0, 4].Value));
            root.Add(new XElement("NotUsed_GreenScalling", dgv_ColourFiltersData[1, 4].Value));
            root.Add(new XElement("NotUsed_BlueScalling", dgv_ColourFiltersData[2, 4].Value));
            root.Add(new XElement("NotUsed_AlphaScalling", dgv_ColourFiltersData[3, 4].Value));
            root.Add(new XElement("NotUsed_ColourCast", dgv_ColourFiltersData[4, 4].Value));

            doc.Element("ColourFilter").Add(root);
            doc.Save("ColourFilterdata.xml");
        }

        private void btn_update_filter_Click(object sender, EventArgs e)
        {
            string FilterName = cmbobx_ColourFilters.Text;

            if (FilterName == "Reset")
            {
                MsgBox.Show("Sorry you cannot update the Filter called Reset", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterdata.xml");

            XmlNode node = doc.SelectSingleNode("//Data[name ='" + FilterName + "']");

            // if found....
            if (node != null)
            {
                node["name"].InnerText = FilterName;
                node["RedByte_RedScalling"].InnerText = dgv_ColourFiltersData[0, 0].Value.ToString();
                node["RedByte_GreenScalling"].InnerText = dgv_ColourFiltersData[1, 0].Value.ToString();
                node["RedByte_BlueScalling"].InnerText = dgv_ColourFiltersData[2, 0].Value.ToString();
                node["RedByte_AlphaScalling"].InnerText = dgv_ColourFiltersData[3, 0].Value.ToString();
                node["RedByte_ColourCast"].InnerText = dgv_ColourFiltersData[4, 0].Value.ToString();

                node["GreenByte_RedScalling"].InnerText = dgv_ColourFiltersData[0, 1].Value.ToString();
                node["GreenByte_GreenScalling"].InnerText = dgv_ColourFiltersData[1, 1].Value.ToString();
                node["GreenByte_BlueScalling"].InnerText = dgv_ColourFiltersData[2, 1].Value.ToString();
                node["GreenByte_AlphaScalling"].InnerText = dgv_ColourFiltersData[3, 1].Value.ToString();
                node["GreenByte_ColourCast"].InnerText = dgv_ColourFiltersData[4, 1].Value.ToString();

                node["BlueByte_RedScalling"].InnerText = dgv_ColourFiltersData[0, 2].Value.ToString();
                node["BlueByte_GreenScalling"].InnerText = dgv_ColourFiltersData[1, 2].Value.ToString();
                node["BlueByte_BlueScalling"].InnerText = dgv_ColourFiltersData[2, 2].Value.ToString();
                node["BlueByte_AlphaScalling"].InnerText = dgv_ColourFiltersData[3, 2].Value.ToString();
                node["BlueByte_ColourCast"].InnerText = dgv_ColourFiltersData[4, 2].Value.ToString();

                node["AlphaByte_RedScalling"].InnerText = dgv_ColourFiltersData[0, 3].Value.ToString();
                node["AlphaByte_GreenScalling"].InnerText = dgv_ColourFiltersData[1, 3].Value.ToString();
                node["AlphaByte_BlueScalling"].InnerText = dgv_ColourFiltersData[2, 3].Value.ToString();
                node["AlphaByte_AlphaScalling"].InnerText = dgv_ColourFiltersData[3, 3].Value.ToString();
                node["AlphaByte_ColourCast"].InnerText = dgv_ColourFiltersData[4, 3].Value.ToString();

                node["NotUsed_RedScalling"].InnerText = dgv_ColourFiltersData[0, 4].Value.ToString();
                node["NotUsed_GreenScalling"].InnerText = dgv_ColourFiltersData[1, 4].Value.ToString();
                node["NotUsed_BlueScalling"].InnerText = dgv_ColourFiltersData[2, 4].Value.ToString();
                node["NotUsed_AlphaScalling"].InnerText = dgv_ColourFiltersData[3, 4].Value.ToString();
                node["NotUsed_ColourCast"].InnerText = dgv_ColourFiltersData[4, 4].Value.ToString();
                
                doc.Save("ColourFilterdata.xml");
            }
        }

        private void btn_delete_filter_Click(object sender, EventArgs e)
        {
            string FilterName = cmbobx_ColourFilters.Text;

            //We do not allow you to delete the reset filter
            if (FilterName == "Reset")
            {
                MsgBox.Show("Sorry you cannot delete the Filter called Reset", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
           
            DeleteData(FilterName);

            PopulateColourFiltersCmboBx("Reset");
        }

        private bool DeleteData(string myAircraftName)
        {
            //bool areYouSure = true;

            //if (grpbx_aircraftname_new.Visible)
            //{
            //    //create a dialog to ask if user is sure they want to delete aircraft
            //    var AreYouSureForm = new AreYouSure(myAircraftName);
            //    AreYouSureForm.ShowDialog();
            //    areYouSure = AreYouSureForm.areYouSureToDelete;
            //}

            //if (areYouSure) //Only delete is yes else ignore
            //{
            //    // create the XML, load the contents
            //    XmlDocument doc = new XmlDocument();
            //    doc.Load("data.xml");

            //    string xQryStr = "//aircraft_info[aircraft_name ='" + myAircraftName + "']";

            //    XmlNode node = doc.SelectSingleNode(xQryStr);

            //    // if found....
            //    if (node != null)
            //    {
            //        // get its parent node
            //        XmlNode parent = node.ParentNode;

            //        // remove the child node
            //        parent.RemoveChild(node);

            //        // verify the new XML structure
            //        string newXML = doc.OuterXml;

            //        // save to file
            //        doc.Save(@"data.xml");
            //    }
            //}

            return true;
        }
    }
}