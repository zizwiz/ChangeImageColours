using System.Windows.Forms;
using System.Xml;
using ColourChanger.data;

namespace ColourChanger.utils
{
    class XMLUtils
    {
        public static void PopulateColourFiltersCmboBx(ComboBox mycombobox)
        {
            // A different thread watch cross threading
            //populate the combo boxes with the airfield names direct from xml file so we get 
            //names correctly spelt for later look up
            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterData.xml");
            XmlNodeList ColourFilterList = doc.SelectNodes("ColourFilter/Data/name");

            foreach (XmlNode Name in ColourFilterList)
            {
                string[] data = ColourFilterData.GetColourFilterData(Name.InnerText);
                mycombobox.Items.Add(Name.InnerText);
            }

            //Set to Cambridge City Airport
            mycombobox.SelectedIndex = 0;
        }
    }
}
