using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyConstruction
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
            //if (MainForm.lib == 0)
            //{
            //    rdoPDFBox.Checked = true;
            //}
            //else if (MainForm.lib == 1)
            //{
            //    rdoItext.Checked = true;
            //}
        }

        private void rdoPDFBox_CheckedChanged(object sender, EventArgs e)
        {
            //MainForm.lib = 0;
        }

        private void rdoItext_CheckedChanged(object sender, EventArgs e)
        {
            //MainForm.lib = 1;
        }
    }
}
