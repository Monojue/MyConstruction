namespace MyConstruction
{
    partial class EditForm
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
            this.lblPath = new System.Windows.Forms.Label();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblConName = new System.Windows.Forms.TextBox();
            this.lblConOutline = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalDate = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.RichTextBox();
            this.lblReason = new System.Windows.Forms.RichTextBox();
            this.lblConNo = new System.Windows.Forms.TextBox();
            this.lblConSite = new System.Windows.Forms.TextBox();
            this.lblEstiAmount = new System.Windows.Forms.TextBox();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.TextBox();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelbottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
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
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelbottom.Controls.Add(this.btnCancel);
            this.panelbottom.Controls.Add(this.pbar);
            this.panelbottom.Controls.Add(this.lblPath);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 564);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(984, 27);
            this.panelbottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(963, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(18, 23);
            this.btnCancel.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 65);
            this.panel1.TabIndex = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 65);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 535);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.panel2.Size = new System.Drawing.Size(984, 29);
            this.panel2.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(335, 1);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(244, 1);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "PDFを開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(428, 1);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 25);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "ダウンロード";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblConName
            // 
            this.lblConName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableMain.SetColumnSpan(this.lblConName, 8);
            this.lblConName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConName.Location = new System.Drawing.Point(239, 12);
            this.lblConName.Name = "lblConName";
            this.lblConName.Size = new System.Drawing.Size(722, 23);
            this.lblConName.TabIndex = 0;
            this.lblConName.TextChanged += new System.EventHandler(this.lblConName_TextChanged);
            // 
            // lblConOutline
            // 
            this.lblConOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableMain.SetColumnSpan(this.lblConOutline, 8);
            this.lblConOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConOutline.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConOutline.Location = new System.Drawing.Point(239, 119);
            this.lblConOutline.Name = "lblConOutline";
            this.lblConOutline.Size = new System.Drawing.Size(722, 58);
            this.lblConOutline.TabIndex = 3;
            this.lblConOutline.Text = "";
            this.lblConOutline.TextChanged += new System.EventHandler(this.lblConOutline_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(880, 185);
            this.label14.Margin = new System.Windows.Forms.Padding(5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 27);
            this.label14.TabIndex = 13;
            this.label14.Text = " Days";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(8, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 90);
            this.label9.TabIndex = 8;
            this.label9.Text = "Remarks";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(8, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 84);
            this.label8.TabIndex = 7;
            this.label8.Text = "Reson for Construction";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(8, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(8, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estimate Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "Construction Outline";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Construction Site";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Construction No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Construction Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(442, 185);
            this.label18.Margin = new System.Windows.Forms.Padding(5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 27);
            this.label18.TabIndex = 19;
            this.label18.Text = "至";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(633, 185);
            this.label21.Margin = new System.Windows.Forms.Padding(5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 27);
            this.label21.TabIndex = 21;
            this.label21.Text = " 施工日数：";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTotalDate.Location = new System.Drawing.Point(736, 185);
            this.lblTotalDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalDate.Name = "lblTotalDate";
            this.lblTotalDate.Size = new System.Drawing.Size(134, 27);
            this.lblTotalDate.TabIndex = 22;
            this.lblTotalDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(241, 185);
            this.label23.Margin = new System.Windows.Forms.Padding(5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 27);
            this.label23.TabIndex = 23;
            this.label23.Text = "自";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(8, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Construction Period";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.White;
            this.tableMain.SetColumnSpan(this.lblRemark, 8);
            this.lblRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemark.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRemark.Location = new System.Drawing.Point(239, 378);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(722, 84);
            this.lblRemark.TabIndex = 9;
            this.lblRemark.Text = "";
            this.lblRemark.TextChanged += new System.EventHandler(this.lblRemark_TextChanged);
            // 
            // lblReason
            // 
            this.lblReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableMain.SetColumnSpan(this.lblReason, 8);
            this.lblReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReason.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblReason.Location = new System.Drawing.Point(239, 294);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(722, 78);
            this.lblReason.TabIndex = 8;
            this.lblReason.Text = "";
            this.lblReason.TextChanged += new System.EventHandler(this.lblReason_TextChanged);
            // 
            // lblConNo
            // 
            this.lblConNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableMain.SetColumnSpan(this.lblConNo, 8);
            this.lblConNo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConNo.Location = new System.Drawing.Point(239, 49);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(722, 23);
            this.lblConNo.TabIndex = 1;
            this.lblConNo.TextChanged += new System.EventHandler(this.lblConNo_TextChanged);
            // 
            // lblConSite
            // 
            this.lblConSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableMain.SetColumnSpan(this.lblConSite, 8);
            this.lblConSite.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConSite.Location = new System.Drawing.Point(239, 86);
            this.lblConSite.Name = "lblConSite";
            this.lblConSite.Size = new System.Drawing.Size(722, 23);
            this.lblConSite.TabIndex = 2;
            this.lblConSite.TextChanged += new System.EventHandler(this.lblConSite_TextChanged);
            // 
            // lblEstiAmount
            // 
            this.lblEstiAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblEstiAmount, 8);
            this.lblEstiAmount.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEstiAmount.Location = new System.Drawing.Point(239, 224);
            this.lblEstiAmount.Name = "lblEstiAmount";
            this.lblEstiAmount.Size = new System.Drawing.Size(722, 23);
            this.lblEstiAmount.TabIndex = 6;
            this.lblEstiAmount.TextChanged += new System.EventHandler(this.lblEstiAmount_TextChanged);
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 9;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11214F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.028038F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07009F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.930934F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07009F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.84232F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07009F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.163669F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.712616F));
            this.tableMain.Controls.Add(this.endPicker, 4, 4);
            this.tableMain.Controls.Add(this.lblPhone, 1, 6);
            this.tableMain.Controls.Add(this.lblEstiAmount, 1, 5);
            this.tableMain.Controls.Add(this.lblConSite, 1, 2);
            this.tableMain.Controls.Add(this.lblConNo, 1, 1);
            this.tableMain.Controls.Add(this.lblReason, 1, 7);
            this.tableMain.Controls.Add(this.lblRemark, 1, 8);
            this.tableMain.Controls.Add(this.label5, 0, 4);
            this.tableMain.Controls.Add(this.label23, 1, 4);
            this.tableMain.Controls.Add(this.lblTotalDate, 6, 4);
            this.tableMain.Controls.Add(this.label21, 5, 4);
            this.tableMain.Controls.Add(this.label18, 3, 4);
            this.tableMain.Controls.Add(this.label1, 0, 0);
            this.tableMain.Controls.Add(this.label2, 0, 1);
            this.tableMain.Controls.Add(this.label3, 0, 2);
            this.tableMain.Controls.Add(this.label4, 0, 3);
            this.tableMain.Controls.Add(this.label6, 0, 5);
            this.tableMain.Controls.Add(this.label7, 0, 6);
            this.tableMain.Controls.Add(this.label8, 0, 7);
            this.tableMain.Controls.Add(this.label9, 0, 8);
            this.tableMain.Controls.Add(this.label14, 7, 4);
            this.tableMain.Controls.Add(this.lblConOutline, 1, 3);
            this.tableMain.Controls.Add(this.lblConName, 1, 0);
            this.tableMain.Controls.Add(this.startPicker, 2, 4);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 65);
            this.tableMain.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.tableMain.RowCount = 9;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222934F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222934F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222934F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.11604F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222934F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222934F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222934F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.27318F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.27318F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(984, 470);
            this.tableMain.TabIndex = 5;
            // 
            // endPicker
            // 
            this.endPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endPicker.CustomFormat = "yyyy/MM/dd";
            this.endPicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(487, 187);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(138, 23);
            this.endPicker.TabIndex = 5;
            this.endPicker.ValueChanged += new System.EventHandler(this.endPicker_ValueChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblPhone, 8);
            this.lblPhone.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPhone.Location = new System.Drawing.Point(239, 261);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(722, 23);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.TextChanged += new System.EventHandler(this.lblPhone_TextChanged);
            // 
            // startPicker
            // 
            this.startPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startPicker.CustomFormat = "yyyy/MM/dd";
            this.startPicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(296, 187);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(138, 23);
            this.startPicker.TabIndex = 4;
            this.startPicker.ValueChanged += new System.EventHandler(this.startPicker_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(978, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.tableMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbottom);
            this.Name = "EditForm";
            this.Text = "DisplayForm";
            this.panelbottom.ResumeLayout(false);
            this.panelbottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox lblConName;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TextBox lblEstiAmount;
        private System.Windows.Forms.TextBox lblConSite;
        private System.Windows.Forms.TextBox lblConNo;
        private System.Windows.Forms.RichTextBox lblReason;
        private System.Windows.Forms.RichTextBox lblRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblTotalDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox lblConOutline;
        private System.Windows.Forms.TextBox lblPhone;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
    }
}