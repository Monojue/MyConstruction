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
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;

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
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private   void   ActivateButton(object  btnSender)
        {
            if   (btnSender !=  null)
            {
                if   (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton =  (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(149, 165, 166);
                    currentButton. ForeColor  = Color. White;
                }
            }
        }

        private   void   DisableButton()
        {
            foreach   (Control previousBtn  in  panelMenu. Controls)
            {
                if   (previousBtn. GetType()  ==  typeof(Button))
                {
                    previousBtn. BackColor  = Color. FromArgb(51,  51,  76);
                    previousBtn. ForeColor  = Color. Gainsboro;
                    previousBtn. Font  =  new  System. Drawing. Font("Microsoft Sans Serif",10F, System. Drawing. FontStyle. Regular, System. Drawing. GraphicsUnit. Point,  ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
