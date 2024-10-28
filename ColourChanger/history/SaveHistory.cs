using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenteredMessagebox;

namespace ColourChanger.history
{
    class SaveHistory
    {

        public static void Save(CheckBox myCheckBoxName, DataGridView myDataGridView)
        {
            string myFileName = myCheckBoxName.Tag.ToString();

            var csvHeaders = new StringBuilder();

            // write the headers to StringBuilder object
            var headers = myDataGridView.Columns.Cast<DataGridViewColumn>();
            csvHeaders.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            // Write the StringBuilder content to a file
             File.WriteAllText(myFileName, csvHeaders.ToString());
        }

        public static void Update(CheckBox myCheckBoxName, DataGridView myDataGridView)
        {
            string myFileName = myCheckBoxName.Tag.ToString();
            var csvData = new StringBuilder();

            // get all the data from the datagridview and add it to the StringBuilder Object
            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                csvData.Append(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                csvData.Append(",");
            }

            // Write the StringBuilder content to the file as a line item
            File.AppendAllText(myFileName, csvData.ToString());

           
        }

        public static void Delete()
        {

        }

    }
}
