using System.Xml;

namespace ColourChanger.data
{
    class ColourFilterData
    {
        public static string[] GetColourFilterData(string ColourFilterName)
        {
            string[] reply = new string[25];


            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ColourFilterData.xml");

                XmlNodeList nodeList;
                XmlNode root = doc.DocumentElement;

                nodeList = root.SelectNodes("descendant::Data[name ='" + ColourFilterName + "']");


                foreach (XmlNode data in nodeList)
                {
                    reply[1] = data["RedByte_RedScalling"].InnerText;
                    reply[2] = data["RedByte_GreenScalling"].InnerText;
                    reply[3] = data["RedByte_BlueScalling"].InnerText;
                    reply[4] = data["RedByte_AlphaScalling"].InnerText;
                    reply[5] = data["RedByte_ColourCast"].InnerText;

                    reply[6] = data["GreenByte_RedScalling"].InnerText;
                    reply[7] = data["GreenByte_GreenScalling"].InnerText;
                    reply[8] = data["GreenByte_BlueScalling"].InnerText;
                    reply[9] = data["GreenByte_AlphaScalling"].InnerText;
                    reply[10] = data["GreenByte_ColourCast"].InnerText;

                    reply[11] = data["BlueByte_RedScalling"].InnerText;
                    reply[12] = data["BlueByte_GreenScalling"].InnerText;
                    reply[13] = data["BlueByte_BlueScalling"].InnerText;
                    reply[14] = data["BlueByte_AlphaScalling"].InnerText;
                    reply[15] = data["BlueByte_ColourCast"].InnerText;

                    reply[16] = data["AlphaByte_RedScalling"].InnerText;
                    reply[17] = data["AlphaByte_GreenScalling"].InnerText;
                    reply[18] = data["AlphaByte_BlueScalling"].InnerText;
                    reply[19] = data["AlphaByte_AlphaScalling"].InnerText;
                    reply[20] = data["AlphaByte_ColourCast"].InnerText;

                    reply[21] = data["NotUsed_RedScalling"].InnerText;
                    reply[22] = data["NotUsed_GreenScalling"].InnerText;
                    reply[23] = data["NotUsed_BlueScalling"].InnerText;
                    reply[24] = data["NotUsed_AlphaScalling"].InnerText;
                    reply[25] = data["NotUsed_ColourCast"].InnerText;
                }
            }
            catch
            {
                reply[0] = "Check the Colour Filter name is correct";
            }
            return reply;
        }
    }
}
