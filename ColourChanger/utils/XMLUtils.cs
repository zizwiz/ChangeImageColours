using System.Windows.Forms;
using System.Xml;
using ColourChanger.data;

namespace ColourChanger.utils
{
    class XMLUtils
    {
        public static void PopulateColourFiltersCmboBx(ComboBox myComboBox)
        {
            // A different thread watch cross threading
            //populate the combo boxes with the airfield names direct from xml file so we get 
            //names correctly spelt for later look up
            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterData.xml");
            XmlNodeList ColourFilterList = doc.SelectNodes("ColourFilter/Data/name");

            foreach (XmlNode Name in ColourFilterList)
            {
                // data is content of each name
                string[] data = ColourFilterData.GetColourFilterData(Name.InnerText);

                myComboBox.Items.Add(Name.InnerText);                
            }

            //use invoke to prevent cross threading
            //Set to "Reset" filter
            myComboBox.SelectedText = "Reset";
            
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




    }
}
