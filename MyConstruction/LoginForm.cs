using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyConstruction
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            txtUserName.Select();
        }


        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this. Handle,  0x112,  0xf012,  0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(txtUserName.Text.Equals("User")) && !(txtPassword.Text.Equals("User")))
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
                
            }
            else if (txtUserName.Text.Equals(string.Empty) || txtPassword.Text.Equals(string.Empty))
             {
                 MessageBox.Show("Please Type UserName and Password!");
            }
            else
            {
                MessageBox.Show("Username or Password is Worng!");
            }
        }
    }
}
