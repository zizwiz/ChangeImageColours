using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourChanger
{
    public partial class FilterName : Form
    {
        public FilterName()
        {
            InitializeComponent();
        }

        public string myFilterName
        {
            get
            {
                if (txtbx_filterName.Text == "")
                {
                    return "error";
                }
                else
                {
                    return txtbx_filterName.Text;
                }

            }
        }

        private void btn_filterName_go_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_filterName_exit_Click(object sender, EventArgs e)
        {
            txtbx_filterName.Text = "error";
            Close();
        }
    }
}
