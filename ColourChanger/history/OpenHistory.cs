using System.IO;
using System.Windows.Forms;
using ColourChanger.utils;

namespace ColourChanger.history
{
    class OpenHistory
    {
        public static void PopulateHistoryDGV(string myFilename, DataGridView myHistoryDataGridView, CheckBox myHistoryCheckBox)
        {
            int numberOfLines = FileUtils.NumberOfLinesInFile(myFilename);
            // int ColumnNumber = 0;

            string[] lines = File.ReadAllLines(myFilename);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                int ColumnNumber = 0;
                int index = myHistoryDataGridView.Rows.Add();

                foreach (string column in columns)
                {
                    myHistoryDataGridView.Rows[index].Cells[ColumnNumber].Value = column;
                    ColumnNumber++;

                    if (ColumnNumber == 7)
                    {
                        index = myHistoryDataGridView.Rows.Add();
                        ColumnNumber = 0;
                    }
                }
            }
        }
    }
}

