using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using org.apache.pdfbox.pdmodel;
//using org.apache.pdfbox.util;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.io;
using iTextSharp.text;


namespace MyConstruction
{
    class Method
    {

        public static List<string> line;
        public static List<string> word;

        public void runExtractor(BackgroundWorker background, string path)
        {
            //if (MainForm.lib == 0) // pdfbox
            //{
            //    pdfbox(background, path);
            //}
            //else if (MainForm.lib == 1) // itextsharp
            //{
            //    iTextSharp(background, path);
            //}
            iTextSharp(background, path);
            dataextract(MainForm.finaltext);
        }

        public void iTextSharp(BackgroundWorker backgroundWorker, string path)
        {
            using (PdfReader reader = new PdfReader(path))
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
                MainForm.finaltext =  builder.ToString();
            }
        }

        public static void dataextract(string data)
        {
            line = data.Split(new[] { "\n" }, StringSplitOptions.None).ToList();
        }

        public static string getdataup(string key)
        {
            try
            {
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i].Contains(key))
                    {
                        return line[i - 1];
                    }
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string getdatadown(string key)
        {
            try
            {
                string data = "";
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i].Contains(key))
                    {
                        for (int j = i + 1; j < line.Count; j++)
                        {
                            data = data + "\n" + line[j];
                        }
                        return data;
                    }
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }


        public string getdataline(string key)
        {
            try
            {
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i].Contains(key))
                    {
                        return line[i].Substring(key.Length + 1);
                    }
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string getdatablock(string skey, string ekey)
        {
            try
            {
                Boolean found = false;
                string block = "";
                for (int i = 0; i <= line.Count; i++)
                {
                    if (found)
                    {
                        if (i == line.Count)
                        {
                            return block;
                        }
                        else if (line[i].Contains(ekey) && !ekey.Equals(string.Empty))
                        {
                            return block;
                        }
                        else
                        {
                            block = block +"\n"+ line[i];
                        }
                    }
                    if (line[i].Contains(skey))
                    {
                        block = line[i].Substring(skey.Length + 1);
                        found = true;
                    }
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public void putData()
        {

            try
            {
                if (MainForm.lib == 0)
                {
                    word = new List<string>();
                    word.Add(line[0]);      // title
                    word.Add(getdataup("Construction Name"));      // name
                    word.Add(getdataup("Construction No").Substring(0, Method.getdataup("Construction No").IndexOf(" ")));      // no
                    word.Add(getdataup("Construction Site"));      // site
                    word.Add(getdatadown("Outline of Construction"));      // outline
                    word.Add(getdataup("Estimate Amount"));      // amount
                    word.Add(getdataup("Phone"));      // phone
                    word.Add(getdataup("Reason for construction"));      // reson
                    word.Add(getdataup("Remarks")); // remarks
                }
                else if (MainForm.lib == 1)
                {
                    word = new List<string>();
                    word.Add(line[0]);      // title
                    word.Add(getdataline("Construction Name"));      // name
                    word.Add(getdataline("Construction No"));      // no
                    word.Add(getdataline("Construction Site"));      // site

                    word.Add(getdatablock("Outline of Construction", "Construction period"));      // outline

                    word.Add(getdataline("Estimate Amount"));      // amount
                    word.Add(getdataline("Phone"));      // phone
                    word.Add(getdatablock("Reason for construction", "Remarks"));      // reson
                    word.Add(getdatablock("Remarks", string.Empty)); // remarks
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PDF is Worng!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
         
        }

        public void createPDF(List<string> update, string path)
        {
             
            Document doc = new Document(PageSize.A4, 5,5,12,12);
            //BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            //BaseFont baseFT = BaseFont.CreateFont("STSong-Light", "UniGB-UCS2-H", BaseFont.EMBEDDED);
            //iTextSharp.text.Font f_15bold = new iTextSharp.text.Font(baseFT);

            try
            {
                FileStream os = new FileStream(path, FileMode.Create);

                using (os)
                {
                    PdfWriter.GetInstance(doc, os);

                    BaseFont bf = BaseFont.CreateFont("Simhei.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                    Font title = new Font(bf, 15, Font.BOLD);
                    Font normal = new Font(bf, 12, Font.NORMAL);
                    float[] columnWidth = { 150,30,70,30,70,75,50,30 };

                    doc.Open();

                    PdfPTable table = new PdfPTable(8);
                    table.SetWidthPercentage(columnWidth, PageSize.A4);
                    table.SpacingAfter = 100;
                    table.SpacingBefore = 100;

                    PdfPCell cell = new PdfPCell(new Phrase(update[0], title));
                    cell.Colspan = 8;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    table.AddCell("Construction Name");
                    cell = new PdfPCell(new Phrase(update[1], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);

                    table.AddCell("Construction No.");
                    cell = new PdfPCell(new Phrase(update[2], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);

                    table.AddCell("Construction Site");
                    cell = new PdfPCell(new Phrase(update[3], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);

                    table.AddCell("Outline of Construction");
                    cell = new PdfPCell(new Phrase(update[4], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);


                    //FontSelector selector = new FontSelector();
                    //selector.AddFont(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                    //selector.AddFont(FontFactory.GetFont("MSung-Light", "UniCNS-UCS2-H", BaseFont.NOT_EMBEDDED));
                    //Phrase ph = selector.Process("你好");
                    //doc.Add(new Paragraph(ph));

                    table.AddCell("Construction period");
                    cell = new PdfPCell(new Phrase("自", normal));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    
                    table.AddCell(cell);
                    table.AddCell(new Phrase(update[5], normal));

                    cell = new PdfPCell(new Phrase("至", normal));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    table.AddCell(update[6]);

                    cell = new PdfPCell(new Phrase("施工日数：", normal));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    table.AddCell(new Phrase(update[7], normal));

                    cell = new PdfPCell(new Phrase("Days", normal));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    table.AddCell("Estimate Amount");
                    cell = new PdfPCell(new Phrase(update[8], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);

                    table.AddCell("Phone");
                    cell = new PdfPCell(new Phrase(update[9], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);

                    table.AddCell("Reason for construction");
                    cell = new PdfPCell(new Phrase(update[10], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);

                    table.AddCell("Remarks");
                    cell = new PdfPCell(new Phrase(update[11], normal));
                    cell.Colspan = 7;
                    table.AddCell(cell);


                    doc.Add(table);

                    doc.Close();
                    System.Diagnostics.Process.Start(path);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
