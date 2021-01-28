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
    public partial class E3Form : Form
    {

        string finaltext = MainForm.finaltext;
        Method method = new Method();
        Boolean firsttime = true;
        Boolean error = false;

        public E3Form()
        {
            InitializeComponent();
            lblPath.Text = MainForm.path;

            if (finaltext.Equals(""))
            {
                if (!backgroundWorker.IsBusy)
                {
                    btnCancel.Visible = true;
                    backgroundWorker.RunWorkerAsync();
                }
            }
            else
            {
                setData();
                pbar.Value = 100;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                method.runExtractor(backgroundWorker, lblPath.Text);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            method.putData();
            setData();
            btnCancel.Visible = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar.Value = e.ProgressPercentage;
            pbar.Update();
        }

        public void setData()
        {
            try
            {
                lblTitle.Text = Method.word[0];
                lblConNo.Text = Method.word[1];
                lblConName.Text = Method.word[2];
                lblPhone.Text = Method.word[3];
                lblRiverName.Text = Method.word[4];
                lblPosition.Text = Method.word[5];
                lblConEnf.Text = Method.word[6];
                lblConOutline.Text = Method.word[7];
                lblFooter.Text = Method.word[8];

                if (MainForm.lib != 5)
                {
                    startPicker.Value = DateTime.Now;
                    endPicker.Value = DateTime.Now.AddMonths(1);
                    lblTotalDate.Text = ((DateTime.Now.AddMonths(1) - DateTime.Now).TotalDays + 1).ToString();
                }
                else
                {
                    startPicker.Value = DateTime.Parse(Method.word[9]);
                    endPicker.Value = DateTime.Parse(Method.word[10]);
                    lblTotalDate.Text = Method.word[11];
                }
                firsttime = false;
                error = false;
            }
            catch (Exception)
            {
                lblTitle.Text = "";
                lblConNo.Text = "";
                lblConName.Text = "";
                lblPhone.Text = "";
                lblRiverName.Text = "";
                lblPosition.Text = "";
                lblConEnf.Text = "";
                lblConOutline.Text = "";
                lblFooter.Text = "";

                startPicker.Value = DateTime.Now;
                endPicker.Value = DateTime.Now.AddMonths(1);
                lblTotalDate.Text = ((DateTime.Now.AddMonths(1) - DateTime.Now).TotalDays + 1).ToString();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF files(*.pdf)|*.pdf";
            if (of.ShowDialog() == DialogResult.OK)
            {
                MainForm.path = lblPath.Text = of.FileName.ToString();
                if (!backgroundWorker.IsBusy)
                {
                    btnCancel.Visible = true;
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        public void checkError()
        {
            Boolean a, b;
            if (lblTotalDate.Text.Contains("-"))
            {
                lblTotalDate.BackColor = Color.LightPink;
                a = true;
            }
            else
            {
                lblTotalDate.BackColor = Color.FromArgb(192, 192, 255);
                a = false;
            }

            if (!lblPhone.Text.Equals(string.Empty) && lblPhone.Text.Length < 8 || !method.isdigit(lblPhone.Text))
            {
                lblPhone.BackColor = Color.LightPink;
                b = true;
            }
            else
            {
                lblPhone.BackColor = Color.White;
                b = false;
            }

            error = a | b;
        }

        private void startPicker_ValueChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;

            lblTotalDate.Text = method.dateDifferent((endPicker.Value - startPicker.Value).TotalDays);

            checkError();
        }

        private void endPicker_ValueChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;

            lblTotalDate.Text = method.dateDifferent((endPicker.Value - startPicker.Value).TotalDays);

            checkError();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                List<string> name = new List<string>();

                name.Add("Date");
                name.Add("Construction No");
                name.Add("Construction Name");
                name.Add("Phone");
                name.Add("River Name");
                name.Add("Position");
                name.Add("Contract enforcement");
                name.Add("Construction outline");

                List<string> update = new List<string>();

                update.Add(lblTitle.Text);
                update.Add(startPicker.Text);
                update.Add(endPicker.Text);
                update.Add(lblTotalDate.Text);

                update.Add(lblConNo.Text);
                update.Add(lblConName.Text);
                update.Add(lblPhone.Text);
                update.Add(lblRiverName.Text);
                update.Add(lblPosition.Text);
                update.Add(lblConEnf.Text);
                update.Add(lblConOutline.Text);
                update.Add(lblFooter.Text);

                string fname = lblPath.Text.ToString();
                saveFileDialog.FileName = fname.Substring(fname.LastIndexOf(@"\") + 1).Replace(".pdf", "") + "(Edit)";
                saveFileDialog.Filter = "PDF files(*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    method.createPDF(name, update, saveFileDialog.FileName.ToString(), 1, true, "3");
                }
            }
            else
            {
                MessageBox.Show(this, "Please Make sure there is no Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void lblConNo_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;
        }

        private void lblConName_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;
        }

        private void lblPhone_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;

            checkError();
        }

        private void lblRiverName_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;
        }

        private void lblPosition_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;
        }

        private void lblConEnf_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;
        }

        private void lblConOutline_TextChanged(object sender, EventArgs e)
        {
            if (!firsttime)
                MainForm.editdatachanged = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                pbar.Value = 100;
                btnCancel.Visible = false;
                backgroundWorker.CancelAsync();
            }
        }
    }
}
