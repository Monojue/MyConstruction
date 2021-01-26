
namespace MyConstruction
{
    partial class D3Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalDate = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblConOutline = new System.Windows.Forms.RichTextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblConEnf = new System.Windows.Forms.Label();
            this.lblConName = new System.Windows.Forms.Label();
            this.lblRiverName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblConNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelbottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // endPicker
            // 
            this.endPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endPicker.CustomFormat = "yyyy/MM/dd";
            this.endPicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(500, 9);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(142, 23);
            this.endPicker.TabIndex = 37;
            this.endPicker.ValueChanged += new System.EventHandler(this.endPicker_ValueChanged);
            // 
            // startPicker
            // 
            this.startPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startPicker.CustomFormat = "yyyy/MM/dd";
            this.startPicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(304, 9);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(142, 23);
            this.startPicker.TabIndex = 36;
            this.startPicker.ValueChanged += new System.EventHandler(this.startPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(8, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(247, 10);
            this.label23.Margin = new System.Windows.Forms.Padding(5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 21);
            this.label23.TabIndex = 23;
            this.label23.Text = "自";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 9;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11214F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.028039F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07009F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.930934F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07009F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.84232F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07009F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.16367F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.712616F));
            this.tableMain.Controls.Add(this.lblTotalDate, 6, 0);
            this.tableMain.Controls.Add(this.lblFooter, 0, 8);
            this.tableMain.Controls.Add(this.lblConOutline, 1, 7);
            this.tableMain.Controls.Add(this.lblPosition, 1, 5);
            this.tableMain.Controls.Add(this.lblConEnf, 1, 6);
            this.tableMain.Controls.Add(this.lblConName, 1, 2);
            this.tableMain.Controls.Add(this.lblRiverName, 1, 4);
            this.tableMain.Controls.Add(this.lblPhone, 1, 3);
            this.tableMain.Controls.Add(this.label8, 0, 5);
            this.tableMain.Controls.Add(this.label7, 0, 7);
            this.tableMain.Controls.Add(this.label6, 0, 6);
            this.tableMain.Controls.Add(this.label4, 0, 4);
            this.tableMain.Controls.Add(this.label3, 0, 3);
            this.tableMain.Controls.Add(this.label1, 0, 2);
            this.tableMain.Controls.Add(this.endPicker, 4, 0);
            this.tableMain.Controls.Add(this.startPicker, 2, 0);
            this.tableMain.Controls.Add(this.label5, 0, 0);
            this.tableMain.Controls.Add(this.label23, 1, 0);
            this.tableMain.Controls.Add(this.label21, 5, 0);
            this.tableMain.Controls.Add(this.label18, 3, 0);
            this.tableMain.Controls.Add(this.lblConNo, 1, 1);
            this.tableMain.Controls.Add(this.label2, 0, 1);
            this.tableMain.Controls.Add(this.label14, 7, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 50);
            this.tableMain.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.tableMain.RowCount = 9;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.234179F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1614F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1614F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.15569F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1614F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1614F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1614F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.80311F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(1008, 418);
            this.tableMain.TabIndex = 9;
            // 
            // lblTotalDate
            // 
            this.lblTotalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDate.AutoSize = true;
            this.lblTotalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTotalDate.Location = new System.Drawing.Point(756, 10);
            this.lblTotalDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalDate.Name = "lblTotalDate";
            this.lblTotalDate.Size = new System.Drawing.Size(138, 21);
            this.lblTotalDate.TabIndex = 52;
            this.lblTotalDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.tableMain.SetColumnSpan(this.lblFooter, 9);
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFooter.Location = new System.Drawing.Point(8, 390);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(977, 23);
            this.lblFooter.TabIndex = 51;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConOutline
            // 
            this.lblConOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableMain.SetColumnSpan(this.lblConOutline, 8);
            this.lblConOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConOutline.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConOutline.Location = new System.Drawing.Point(245, 297);
            this.lblConOutline.Name = "lblConOutline";
            this.lblConOutline.ReadOnly = true;
            this.lblConOutline.Size = new System.Drawing.Size(740, 90);
            this.lblConOutline.TabIndex = 50;
            this.lblConOutline.Text = "";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblPosition, 8);
            this.lblPosition.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPosition.Location = new System.Drawing.Point(247, 213);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(5);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(736, 33);
            this.lblPosition.TabIndex = 49;
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConEnf
            // 
            this.lblConEnf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConEnf.AutoSize = true;
            this.lblConEnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblConEnf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblConEnf, 8);
            this.lblConEnf.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConEnf.Location = new System.Drawing.Point(247, 256);
            this.lblConEnf.Margin = new System.Windows.Forms.Padding(5);
            this.lblConEnf.Name = "lblConEnf";
            this.lblConEnf.Size = new System.Drawing.Size(736, 33);
            this.lblConEnf.TabIndex = 48;
            this.lblConEnf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConName
            // 
            this.lblConName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConName.AutoSize = true;
            this.lblConName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblConName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblConName, 8);
            this.lblConName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConName.Location = new System.Drawing.Point(247, 84);
            this.lblConName.Margin = new System.Windows.Forms.Padding(5);
            this.lblConName.Name = "lblConName";
            this.lblConName.Size = new System.Drawing.Size(736, 33);
            this.lblConName.TabIndex = 47;
            this.lblConName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRiverName
            // 
            this.lblRiverName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRiverName.AutoSize = true;
            this.lblRiverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRiverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblRiverName, 8);
            this.lblRiverName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRiverName.Location = new System.Drawing.Point(247, 170);
            this.lblRiverName.Margin = new System.Windows.Forms.Padding(5);
            this.lblRiverName.Name = "lblRiverName";
            this.lblRiverName.Size = new System.Drawing.Size(736, 33);
            this.lblRiverName.TabIndex = 46;
            this.lblRiverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblPhone, 8);
            this.lblPhone.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPhone.Location = new System.Drawing.Point(247, 127);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(736, 33);
            this.lblPhone.TabIndex = 45;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(8, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 43);
            this.label8.TabIndex = 43;
            this.label8.Text = "Position";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(8, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 96);
            this.label7.TabIndex = 42;
            this.label7.Text = "Construction Outline";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(8, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 43);
            this.label6.TabIndex = 41;
            this.label6.Text = "Contract enforcement";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 43);
            this.label4.TabIndex = 40;
            this.label4.Text = "River Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 43);
            this.label3.TabIndex = 39;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 43);
            this.label1.TabIndex = 38;
            this.label1.Text = "Construction Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(650, 10);
            this.label21.Margin = new System.Windows.Forms.Padding(5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 21);
            this.label21.TabIndex = 21;
            this.label21.Text = " 施工日数：";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(454, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 21);
            this.label18.TabIndex = 19;
            this.label18.Text = "至";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConNo
            // 
            this.lblConNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConNo.AutoSize = true;
            this.lblConNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblConNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableMain.SetColumnSpan(this.lblConNo, 8);
            this.lblConNo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConNo.Location = new System.Drawing.Point(247, 41);
            this.lblConNo.Margin = new System.Windows.Forms.Padding(5);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(736, 33);
            this.lblConNo.TabIndex = 10;
            this.lblConNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Construction No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(904, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = " Days";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDownload
            // 
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(332, 1);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 25);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "ダウンロード";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Yu Mincho", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPath.Location = new System.Drawing.Point(9, 6);
            this.lblPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(18, 17);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "lb";
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(244, 1);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "PDFを開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.panel2.Size = new System.Drawing.Size(1008, 29);
            this.panel2.TabIndex = 8;
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelbottom.Controls.Add(this.btnCancel);
            this.panelbottom.Controls.Add(this.pbar);
            this.panelbottom.Controls.Add(this.lblPath);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 497);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(1008, 27);
            this.panelbottom.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(963, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(18, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "✖";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(872, 7);
            this.pbar.Margin = new System.Windows.Forms.Padding(10);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(89, 13);
            this.pbar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1008, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Construction ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 50);
            this.panel1.TabIndex = 7;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // D3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 524);
            this.Controls.Add(this.tableMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panel1);
            this.Name = "D3Form";
            this.Text = "DForm";
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelbottom.ResumeLayout(false);
            this.panelbottom.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblConEnf;
        private System.Windows.Forms.Label lblConName;
        private System.Windows.Forms.Label lblRiverName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox lblConOutline;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblTotalDate;
    }
}