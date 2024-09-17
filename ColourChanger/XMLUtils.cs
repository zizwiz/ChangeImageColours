using System;
using System.Xml;
using ColourChanger.data;

namespace ColourChanger
{
    public partial class Form1
    {
        void PopulateAirfieldCmboBx()
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
                
                //use invoke to prevent cross threading
                BeginInvoke(new Action(() =>
                {
                    cmbobx_ColourFilters.Items.Add(Name.InnerText);
                }));
            }

            //use invoke ot prevent cross threading
            //Set to Cambridge City Airport
            BeginInvoke(new Action(() =>
            {
                cmbobx_ColourFilters.SelectedIndex = 0;
            }));
        }




    }
}