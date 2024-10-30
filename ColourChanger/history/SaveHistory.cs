using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ColourChanger.utils;

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

        public static void Update(CheckBox myHistoryCheckBoxName, DataGridView myDataGridView, ComboBox myComboBox, CheckBox mySuperimposeCheckBox)
        {
            string myFileName = myHistoryCheckBoxName.Tag.ToString();
            var csvData = new StringBuilder();

            // get all the data from the datagridview and add it to the StringBuilder Object
            // add comma after each line
            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
               // csvData.Append(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));

                csvData.Append(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
                csvData.Append(",");
            }

            // Write the StringBuilder content to the file as a line item, also remove last comma
            if (FileUtils.NumberOfLinesInFile(myFileName) > 1)
            {
                //More than just the headers
                File.AppendAllText(myFileName, "\r" + csvData.ToString() + myComboBox.Text + "," + mySuperimposeCheckBox.CheckState);
            }
            else
            {
                //no carriage return first time round
                File.AppendAllText(myFileName, csvData.ToString() + myComboBox.Text + "," + mySuperimposeCheckBox.CheckState);
            }
        }
    }
}
