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
    public partial class D4Form : Form
    {
        Method method = new Method();

        public D4Form()
        {
            InitializeComponent();
            lblPath.Text = MainForm.path;

            if (MainForm.finaltext.Equals(""))
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
            MainForm.editdatachanged = false;
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
            btnCancel.Visible = false;
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
                lblConName.Text = Method.word[1];
                lblBusName.Text = Method.word[2];
                lblContorName.Text = Method.word[3];
                lblPhone.Text = Method.word[4];
                lblDesName.Text = Method.word[5];
                lblFactoryPlace.Text = Method.word[6];
                lblConNumber.Text = Method.word[7];
                lblUPAL.Text = Method.word[8];
                lblConYear.Text = Method.word[9];
                lblFooter.Text = Method.word[10];

                startPicker.Value = DateTime.Now;
                endPicker.Value = DateTime.Now.AddMonths(1);
                lblTotalDate.Text = ((DateTime.Now.AddMonths(1) - DateTime.Now).TotalDays + 1).ToString();
            }
            catch (Exception)
            {
                lblTitle.Text = "";
                lblConName.Text = "";
                lblBusName.Text = "";
                lblContorName.Text = "";
                lblPhone.Text = "";
                lblDesName.Text = "";
                lblFactoryPlace.Text = "";
                lblConNumber.Text = "";
                lblUPAL.Text = "";
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            List<string> name = new List<string>();

            name.Add("Date");
            name.Add("Construction Name");
            name.Add("Business Name");
            name.Add("Constructor Name");
            name.Add("Phone");
            name.Add("Designer Name");
            name.Add("Factory Place");
            name.Add("Construction Number");
            name.Add("Unit Price Appropriate land");
            name.Add("Construction year");
            

            List<string> update = new List<string>();

            update.Add(lblTitle.Text);
            update.Add(startPicker.Text);
            update.Add(endPicker.Text);
            update.Add(lblTotalDate.Text);

            update.Add(lblConName.Text);
            update.Add(lblBusName.Text);
            update.Add(lblContorName.Text);
            update.Add(lblPhone.Text);
            update.Add(lblDesName.Text);
            update.Add(lblFactoryPlace.Text);
            update.Add(lblConNumber.Text);
            update.Add(lblUPAL.Text);
            update.Add(lblConYear.Text);
            update.Add(lblFooter.Text);

            string fname = lblPath.Text.ToString();
            saveFileDialog.FileName = fname.Substring(fname.LastIndexOf(@"\") + 1).Replace(".pdf", "") + "(Display)";
            saveFileDialog.Filter = "PDF files(*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                method.createPDF(name, update, saveFileDialog.FileName.ToString(), 1, true, "4");
            }
        }

        private void startPicker_ValueChanged(object sender, EventArgs e)
        {
            lblTotalDate.Text = Math.Round((endPicker.Value - startPicker.Value).TotalDays + 1).ToString();
        }

        private void endPicker_ValueChanged(object sender, EventArgs e)
        {
            lblTotalDate.Text = Math.Round((endPicker.Value - startPicker.Value).TotalDays + 1).ToString();
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
