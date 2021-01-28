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
        public static string mpath;

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

        public Boolean isdigit(string data)
        {

            char[] cdata = data.ToCharArray();

            foreach(char c in cdata)
            {
                if (!Char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public string dateDifferent(double noOfDate)
        {
            double i = Math.Round(noOfDate + 1);

            if (i > 0)
            {
                i = Math.Round(noOfDate + 1);
            }
            else
            {
                i = Math.Round(noOfDate);
            }

            return i.ToString();
        }

        public void iTextSharp(BackgroundWorker backgroundWorker, string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                mpath = path;
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

        public static List<string> periodSpliter(string key)
        {
            List<string> list = new List<string>();

            try
            {
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i].Contains(key))
                    {
                        list.Add(line[i].Substring(line[i].IndexOf("自") + 2, 10));
                        list.Add(line[i].Substring(line[i].IndexOf("至") + 2, 10));
                        list.Add(line[i].Substring(line[i].IndexOf("施工日数：") + 6).Replace("Days", ""));
                    }
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
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
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i].Contains(key))
                    {
                        return line[i + 1];
                    }
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string getdatadownblock(string key)
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
                            data = data + line[j] + "\n";
                        }
                        return data.Trim();
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


        public string getdatakeyinMiddle(string key, int up, int down)
        {
            try
            {
                string block = "";
                for (int i = 0; i <= line.Count; i++)
                {
                    if (line[i].Contains(key))
                    {
                       
                        for(int j = i-up; j<= i+down; j++)
                        {
                            if (!line[j].Contains(key))
                            {
                                block = block + "\n" + line[j];
                            }
                        }

                        return block.Trim();
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
                    else if (line[i].Contains(skey))
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
                if (MainForm.lib == 1)
                {
                    word = new List<string>();
                    word.Add(line[4]);      // title
                    word.Add(getdataline("Construction Name"));      // name
                    word.Add(getdataline("Construction No"));      // no
                    word.Add(getdataline("Construction Site"));      // site
                    word.Add(getdatablock("Construction outline", "Reason for construction"));      // outline
                    word.Add(getdataline("Estimate Amount"));      // amount
                    word.Add(getdataline("Phone"));      // phone
                    word.Add(getdataline("Reason for construction"));      // reson
                    word.Add(getdatablock("Remarks", string.Empty)); // remarks                  
                }
                else if (MainForm.lib == 2)
                { 
                    word = new List<string>();
                    word.Add(line[0]);      // title
                    word.Add(getdataup("Construction Name"));      // name
                    word.Add(getdataup("Construction No").Substring(0, Method.getdataup("Construction No").IndexOf(" ")));      // no
                    word.Add(getdataup("Construction Site"));      // site
                    word.Add(getdatadownblock("Outline of Construction"));      // outline
                    word.Add(getdataup("Estimate Amount"));      // amount
                    word.Add(getdataup("Phone"));      // phone
                    word.Add(getdataup("Reason for construction"));      // reson
                    word.Add(getdataup("Remarks")); // remarks
                }
                else if (MainForm.lib == 3)
                {
                    word = new List<string>();
                    word.Add(line[0].Substring(line[0].IndexOf("度")+1).Trim());
                    word.Add(getdataline("Construction No"));
                    word.Add(getdataline("Construction Name"));
                    word.Add(getdataline("Phone"));

                    word.Add(getdataline("River Name"));

                    word.Add(getdatablock("Position", "Contract enforcement"));
                    word.Add(getdatadown("Contract enforcement")); 
                    word.Add(getdatakeyinMiddle("Construction outline", 2, 1));
                    word.Add(line[line.Count-1]); 
                }
                else if (MainForm.lib == 4)
                {
                    word = new List<string>();
                    word.Add(line[1]);     
                    word.Add(getdataline("Construction name"));      
                    word.Add(getdataline("Business name"));     
                    word.Add(getdataline("Constructor name"));      

                    word.Add(getdataline("Phone"));      

                    word.Add(getdataline("Designer name"));      
                    word.Add(getdataline("Factory Place"));      
                    word.Add(getdataline("construction number"));
                    word.Add(getdataline("Unit price Appropriate land"));
                    word.Add(getdataline("Construction  year"));
                    word.Add(line[line.Count - 1]);
                }
                else if (MainForm.lib == 5)
                {
                    
                    PdfReader reader = new PdfReader(mpath);
                    string key = reader.Info["Keywords"];
                    word = new List<string>();
                    switch (key)
                    {
                        case "12":
                            word.Add(line[0]);      // title
                            word.Add(getdataline("Construction Name"));      // name
                            word.Add(getdataline("Construction No"));      // no
                            word.Add(getdataline("Construction Site"));      // site
                            word.Add(getdatablock("Outline of Construction", "Construction period"));      // outline
                            word.Add(getdataline("Estimate Amount"));      // amount
                            word.Add(getdataline("Phone"));      // phone
                            word.Add(getdataline("Reason for construction"));      // reson
                            word.Add(getdatablock("Remarks", string.Empty)); // remarks

                            word.Add(periodSpliter("Construction period")[0]);
                            word.Add(periodSpliter("Construction period")[1]);
                            word.Add(periodSpliter("Construction period")[2]);
                            break;


                        case "3":
                            word.Add(line[0]);
                            word.Add(getdataline("Construction No"));
                            word.Add(getdataline("Construction Name"));
                            word.Add(getdataline("Phone"));

                            word.Add(getdataline("River Name"));

                            word.Add(getdataline("Position"));
                            word.Add(getdataline("Contract enforcement"));
                            word.Add(getdatablock("Construction outline", line[line.Count-1]));
                            word.Add(line[line.Count - 1]);

                            word.Add(periodSpliter("Date")[0]);
                            word.Add(periodSpliter("Date")[1]);
                            word.Add(periodSpliter("Date")[2]);
                            break;


                        case "4":
                            word.Add(line[0]);
                            word.Add(getdatablock("Construction Name", "Business Name"));
                            word.Add(getdataline("Business Name"));
                            word.Add(getdataline("Constructor Name"));

                            word.Add(getdataline("Phone"));

                            word.Add(getdataline("Designer Name"));
                            word.Add(getdataline("Factory Place"));
                            word.Add(getdataline("Construction Number"));
                            word.Add(getdataline("Unit Price Appropriate land"));
                            word.Add(getdataline("Construction year"));
                            word.Add(line[line.Count - 1]);

                            word.Add(periodSpliter("Date")[0]);
                            word.Add(periodSpliter("Date")[1]);
                            word.Add(periodSpliter("Date")[2]);
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("PDF is Worng!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
         
        }

        public void createPDF(List<string> name ,List<string> update, string path, int sprow, Boolean footer, string keyword)
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

                    int j = 0;
                    int length = update.Count;

                    if (footer)
                    {
                        length--; ;
                    }

                    for (int i = 1; i < length; i++)
                    {
                        if(sprow == i)
                        {
                            table.AddCell(name[j]);
                            cell = new PdfPCell(new Phrase("自", normal));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;

                            table.AddCell(cell);
                            table.AddCell(new Phrase(update[i], normal));

                            cell = new PdfPCell(new Phrase("至", normal));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                            table.AddCell(update[i+1]);

                            cell = new PdfPCell(new Phrase("施工日数：", normal));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                            table.AddCell(new Phrase(update[i+2], normal));

                            cell = new PdfPCell(new Phrase("Days", normal));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);

                            i = i + 2;
                        }
                        else
                        {
                            table.AddCell(name[j]);
                            cell = new PdfPCell(new Phrase(update[i], normal));
                            cell.Colspan = 7;
                            table.AddCell(cell);
                        }
                        j++;
                        
                    }

                    if (footer)
                    {
                        cell = new PdfPCell(new Phrase(update[update.Count-1], normal));
                        cell.Colspan = 8;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    doc.Add(table);
                    doc.AddKeywords(keyword);
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
