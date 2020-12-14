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
    public partial class EditForm : Form
    {
        string finaltext = MainForm.finaltext;
        List<string> sptext;

        public EditForm()
        {
            InitializeComponent();
            lblPath.Text = MainForm.path;

            if (finaltext.Equals(""))
            {
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync();
                }
            }
            else
            {
                setData();
                pbar.Value = 100;
            }
        }


        public void iTextSharp()
        {
            using (PdfReader reader = new PdfReader(lblPath.Text))
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress((i * 100) / reader.NumberOfPages);
                        //bulider.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                        string s = PdfTextExtractor.GetTextFromPage(reader, i, its);
                        //s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                        builder.Append(s);
                    }
                }
                dataextract(builder.ToString());
                //finaltext = getdata("Construction Name");
                MainForm.finaltext = finaltext = builder.ToString();
            }
        }

        public void dataextract(string data)
        {
            sptext = data.Split(new[] { "\n" }, StringSplitOptions.None).ToList();
        }

        public string getdataup(string key)
        {
            for (int i = 0; i < sptext.Count; i++)
            {
                if (sptext[i].Contains(key))
                {
                    return sptext[i - 1];
                }
            }
            return "Empty";
        }

        public string getdatadown(string key)
        {
            string data = "";
            for (int i = 0; i < sptext.Count; i++)
            {
                if (sptext[i].Contains(key))
                {
                    for (int j=i+1; j < sptext.Count; j++)
                    {
                        data = data +"\n"+ sptext[j];
                    }
                    return data;
                }
            }
            return "Empty";
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                 iTextSharp();
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setData();
            //MessageBox.Show("Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void setData()
        {
            try
            {
                dataextract(finaltext);
                lblTitle.Text = sptext[0];
                lblConName.Text = getdataup("Construction Name");
                lblConNo.Text = getdataup("Construction No").Substring(0, getdataup("Construction No").IndexOf(" "));
                lblConSite.Text = getdataup("Construction Site");
                lblConOutline.Text = getdatadown("Outline of Construction");
                lblEstiAmount.Text = getdataup("Estimate Amount");
                startPicker.Value = DateTime.Now;
                endPicker.Value = DateTime.Now.AddMonths(1);
                lblTotalDate.Text = ((DateTime.Now.AddMonths(1) - DateTime.Now).TotalDays + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("PDF setting Wrong!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar.Value = e.ProgressPercentage;
            pbar.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF files(*.pdf)|*.pdf";
            if (of.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = of.FileName.ToString();
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }


        private void startPicker_ValueChanged(object sender, EventArgs e)
        {
            endPicker.Value = startPicker.Value.AddMonths(1);
            lblTotalDate.Text = ((endPicker.Value - startPicker.Value).TotalDays + 1).ToString();
        }

        private void endPicker_ValueChanged(object sender, EventArgs e)
        {
            startPicker.Value = endPicker.Value.AddMonths(-1);
            lblTotalDate.Text = ((endPicker.Value - startPicker.Value).TotalDays + 1).ToString();
        }

    }
}
