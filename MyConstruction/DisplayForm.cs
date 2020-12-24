using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace MyConstruction
{
    public partial class DisplayForm : Form
    {
       
        //List<string> sptext;
        Method method = new Method();

        public DisplayForm()
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
            //MessageBox.Show("Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                lblConNo.Text = Method.word[2];
                lblConSite.Text = Method.word[3];
                lblConOutline.Text = Method.word[4];
                lblEstiAmount.Text = Method.word[5];
                lblPhone.Text = Method.word[6];
                lblReason.Text = Method.word[7];
                lblRemark.Text = Method.word[8];

                startPicker.Value = DateTime.Now;
                endPicker.Value = DateTime.Now.AddMonths(1);
                lblTotalDate.Text = ((DateTime.Now.AddMonths(1) - DateTime.Now).TotalDays + 1).ToString();
            }
            catch (Exception)
            {
                lblTitle.Text = "";
                lblConName.Text = "";
                lblConNo.Text = "";
                lblConSite.Text = "";
                lblConOutline.Text = "";
                lblEstiAmount.Text = "";
                lblPhone.Text = "";
                lblReason.Text = "";
                lblRemark.Text = "";

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
            List<string> update = new List<string>();

            update.Add(lblTitle.Text);
            update.Add(lblConName.Text);
            update.Add(lblConNo.Text);
            update.Add(lblConSite.Text);
            update.Add(lblConOutline.Text);
            update.Add(startPicker.Text);
            update.Add(endPicker.Text);
            update.Add(lblTotalDate.Text);
            update.Add(lblEstiAmount.Text);
            update.Add(lblPhone.Text);
            update.Add(lblReason.Text);
            update.Add(lblRemark.Text);

            string fname = lblPath.Text.ToString();
            saveFileDialog.FileName = fname.Substring(fname.LastIndexOf(@"\") + 1).Replace(".pdf", "") + "(Display)";
            saveFileDialog.Filter = "PDF files(*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                method.createPDF(update, saveFileDialog.FileName.ToString());
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
