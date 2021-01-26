
namespace MyConstruction
{
    partial class E4Form
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
            this.panelbottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lblPath = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblConYear = new System.Windows.Forms.TextBox();
            this.lblUPAL = new System.Windows.Forms.TextBox();
            this.lblConNumber = new System.Windows.Forms.TextBox();
            this.lblFactoryPlace = new System.Windows.Forms.TextBox();
            this.lblDesName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.TextBox();
            this.lblContorName = new System.Windows.Forms.TextBox();
            this.lblBusName = new System.Windows.Forms.TextBox();
            this.lblConName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalDate = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelbottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelbottom.Controls.Add(this.btnCancel);
            this.panelbottom.Controls.Add(this.pbar);
            this.panelbottom.Controls.Add(this.lblPath);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 590);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(1008, 27);
            this.panelbottom.TabIndex = 13;
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
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
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
            this.panel1.TabIndex = 14;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.panel2.Size = new System.Drawing.Size(1008, 29);
            this.panel2.TabIndex = 18;
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
            // lblConYear
            // 
            this.lblConYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblConYear, 7);
            this.lblConYear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConYear.Location = new System.Drawing.Point(245, 450);
            this.lblConYear.Name = "lblConYear";
            this.lblConYear.Size = new System.Drawing.Size(711, 23);
            this.lblConYear.TabIndex = 63;
            this.lblConYear.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // lblUPAL
            // 
            this.lblUPAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblUPAL, 7);
            this.lblUPAL.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUPAL.Location = new System.Drawing.Point(245, 404);
            this.lblUPAL.Name = "lblUPAL";
            this.lblUPAL.Size = new System.Drawing.Size(711, 23);
            this.lblUPAL.TabIndex = 62;
            this.lblUPAL.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lblConNumber
            // 
            this.lblConNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblConNumber, 7);
            this.lblConNumber.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConNumber.Location = new System.Drawing.Point(245, 358);
            this.lblConNumber.Name = "lblConNumber";
            this.lblConNumber.Size = new System.Drawing.Size(711, 23);
            this.lblConNumber.TabIndex = 61;
            this.lblConNumber.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblFactoryPlace
            // 
            this.lblFactoryPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblFactoryPlace, 7);
            this.lblFactoryPlace.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFactoryPlace.Location = new System.Drawing.Point(245, 312);
            this.lblFactoryPlace.Name = "lblFactoryPlace";
            this.lblFactoryPlace.Size = new System.Drawing.Size(711, 23);
            this.lblFactoryPlace.TabIndex = 60;
            this.lblFactoryPlace.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblDesName
            // 
            this.lblDesName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblDesName, 7);
            this.lblDesName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDesName.Location = new System.Drawing.Point(245, 266);
            this.lblDesName.Name = "lblDesName";
            this.lblDesName.Size = new System.Drawing.Size(711, 23);
            this.lblDesName.TabIndex = 59;
            this.lblDesName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblPhone, 7);
            this.lblPhone.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPhone.Location = new System.Drawing.Point(245, 220);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(711, 23);
            this.lblPhone.TabIndex = 58;
            this.lblPhone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblContorName
            // 
            this.lblContorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblContorName, 7);
            this.lblContorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblContorName.Location = new System.Drawing.Point(245, 174);
            this.lblContorName.Name = "lblContorName";
            this.lblContorName.Size = new System.Drawing.Size(711, 23);
            this.lblContorName.TabIndex = 57;
            this.lblContorName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblBusName
            // 
            this.lblBusName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblBusName, 7);
            this.lblBusName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBusName.Location = new System.Drawing.Point(245, 128);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(711, 23);
            this.lblBusName.TabIndex = 56;
            this.lblBusName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblConName
            // 
            this.lblConName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.SetColumnSpan(this.lblConName, 7);
            this.lblConName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblConName.Location = new System.Drawing.Point(245, 82);
            this.lblConName.Name = "lblConName";
            this.lblConName.Size = new System.Drawing.Size(711, 23);
            this.lblConName.TabIndex = 55;
            this.lblConName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(904, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 36);
            this.label14.TabIndex = 13;
            this.label14.Text = " Days";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Construction Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(454, 30);
            this.label18.Margin = new System.Windows.Forms.Padding(5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 36);
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
            this.label21.Location = new System.Drawing.Point(650, 30);
            this.label21.Margin = new System.Windows.Forms.Padding(5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 36);
            this.label21.TabIndex = 21;
            this.label21.Text = " 施工日数：";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDate
            // 
            this.lblTotalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDate.AutoSize = true;
            this.lblTotalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTotalDate.Location = new System.Drawing.Point(756, 39);
            this.lblTotalDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalDate.Name = "lblTotalDate";
            this.lblTotalDate.Size = new System.Drawing.Size(138, 18);
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
            this.label23.Location = new System.Drawing.Point(247, 30);
            this.label23.Margin = new System.Windows.Forms.Padding(5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 36);
            this.label23.TabIndex = 23;
            this.label23.Text = "自";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 46);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startPicker
            // 
            this.startPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startPicker.CustomFormat = "yyyy/MM/dd";
            this.startPicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(304, 36);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(142, 23);
            this.startPicker.TabIndex = 36;
            this.startPicker.ValueChanged += new System.EventHandler(this.startPicker_ValueChanged);
            // 
            // endPicker
            // 
            this.endPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endPicker.CustomFormat = "yyyy/MM/dd";
            this.endPicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(500, 36);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(142, 23);
            this.endPicker.TabIndex = 37;
            this.endPicker.ValueChanged += new System.EventHandler(this.endPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 46);
            this.label1.TabIndex = 38;
            this.label1.Text = "Business Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 46);
            this.label3.TabIndex = 39;
            this.label3.Text = "Constructor Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(8, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 46);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phone";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(8, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 46);
            this.label6.TabIndex = 41;
            this.label6.Text = "Factory Place";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(8, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 46);
            this.label7.TabIndex = 42;
            this.label7.Text = "Construction Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(8, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 46);
            this.label8.TabIndex = 43;
            this.label8.Text = "Designer Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(8, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 46);
            this.label9.TabIndex = 44;
            this.label9.Text = "Unit Price Appropriate land";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.tableMain.SetColumnSpan(this.lblFooter, 9);
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFooter.Location = new System.Drawing.Point(8, 485);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(977, 21);
            this.lblFooter.TabIndex = 50;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(8, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 46);
            this.label10.TabIndex = 54;
            this.label10.Text = "Construction year";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableMain.Controls.Add(this.label10, 0, 10);
            this.tableMain.Controls.Add(this.lblFooter, 0, 11);
            this.tableMain.Controls.Add(this.label9, 0, 9);
            this.tableMain.Controls.Add(this.label8, 0, 6);
            this.tableMain.Controls.Add(this.label7, 0, 8);
            this.tableMain.Controls.Add(this.label6, 0, 7);
            this.tableMain.Controls.Add(this.label4, 0, 5);
            this.tableMain.Controls.Add(this.label3, 0, 4);
            this.tableMain.Controls.Add(this.label1, 0, 3);
            this.tableMain.Controls.Add(this.endPicker, 4, 1);
            this.tableMain.Controls.Add(this.startPicker, 2, 1);
            this.tableMain.Controls.Add(this.label5, 0, 1);
            this.tableMain.Controls.Add(this.label23, 1, 1);
            this.tableMain.Controls.Add(this.lblTotalDate, 6, 1);
            this.tableMain.Controls.Add(this.label21, 5, 1);
            this.tableMain.Controls.Add(this.label18, 3, 1);
            this.tableMain.Controls.Add(this.label2, 0, 2);
            this.tableMain.Controls.Add(this.label14, 7, 1);
            this.tableMain.Controls.Add(this.lblConName, 1, 2);
            this.tableMain.Controls.Add(this.lblBusName, 1, 3);
            this.tableMain.Controls.Add(this.lblContorName, 1, 4);
            this.tableMain.Controls.Add(this.lblPhone, 1, 5);
            this.tableMain.Controls.Add(this.lblDesName, 1, 6);
            this.tableMain.Controls.Add(this.lblFactoryPlace, 1, 7);
            this.tableMain.Controls.Add(this.lblConNumber, 1, 8);
            this.tableMain.Controls.Add(this.lblUPAL, 1, 9);
            this.tableMain.Controls.Add(this.lblConYear, 1, 10);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 50);
            this.tableMain.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.tableMain.RowCount = 11;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(1008, 511);
            this.tableMain.TabIndex = 19;
            // 
            // E4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 617);
            this.Controls.Add(this.tableMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panel1);
            this.Name = "E4Form";
            this.Text = "E4Form";
            this.panelbottom.ResumeLayout(false);
            this.panelbottom.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label lblPath;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox lblConYear;
        private System.Windows.Forms.TextBox lblUPAL;
        private System.Windows.Forms.TextBox lblConNumber;
        private System.Windows.Forms.TextBox lblFactoryPlace;
        private System.Windows.Forms.TextBox lblDesName;
        private System.Windows.Forms.TextBox lblPhone;
        private System.Windows.Forms.TextBox lblContorName;
        private System.Windows.Forms.TextBox lblBusName;
        private System.Windows.Forms.TextBox lblConName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotalDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label label10;
    }
}