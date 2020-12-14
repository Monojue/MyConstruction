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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
            lblPath.Text = MainForm.path;
            lblPhone.Text = "Watering block installation work 104.5 m\nSnow-melting plumber (sprinkler pipe) 213.5 m\nSnow-melting plumber (water pipe) 106.5 m";
        }

    }
}
