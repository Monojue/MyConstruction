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
        public static string finaltext = "";
        public static Boolean editdatachanged = false;
        public static Boolean firsttime = true;
        public static int lib = 0;

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

            if (MainForm.lib == 0)
            {
                rdo1.Checked = true;
            }
            else if (MainForm.lib == 1)
            {
                rdo2.Checked = true;
            }
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

        private void ActivateButton(object  btnSender)
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

        private void DisableButton()
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

        public void OpenChildForm(Form childForm,  object  btnSender)
        {
            if(activeForm !=  null)
                activeForm. Close();

            if(btnSender != null)
                ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel  =  false;
            childForm.FormBorderStyle  = FormBorderStyle.None;
            childForm.Dock  = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag  = childForm;
            childForm. BringToFront();
            childForm. Show();
        }

        public static string path;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF files(*.pdf)|*.pdf";
            if (of.ShowDialog() == DialogResult.OK)
            {
                path = of.FileName.ToString();
                if (sender.Equals(btnEdit))
                {
                    OpenChildForm(new EditForm(), btnEdit);
                }
                else
                {
                    OpenChildForm(new DisplayForm(), btnDisplay);
                }
                
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (finaltext.Equals(""))
            {
                btnAdd_Click(sender, e);
            }
            else
            {
                if (editdatachanged)
                {
                    if (MessageBox.Show("Your Changed Data will be lost!", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        OpenChildForm(new DisplayForm(), sender);
                    }
                }
                else
                {
                    OpenChildForm(new DisplayForm(), sender);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (finaltext.Equals(""))
            {
                btnAdd_Click(sender, e);
            }
            else
            {
                OpenChildForm(new EditForm(), sender);
            }
        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.lib = 0;
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.lib = 1;
        }


    }
}
