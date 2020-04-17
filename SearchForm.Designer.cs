namespace FindFiles
{
	partial class SearchForm
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
			this.btnDirectory = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbFileNameContains = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblSize = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDirectory
			// 
			this.btnDirectory.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDirectory.Location = new System.Drawing.Point(68, 12);
			this.btnDirectory.Name = "btnDirectory";
			this.btnDirectory.Size = new System.Drawing.Size(143, 39);
			this.btnDirectory.TabIndex = 0;
			this.btnDirectory.Text = "ChooseDirectory";
			this.btnDirectory.UseVisualStyleBackColor = true;
			this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "txt",
            "doc",
            "docx",
            "xml",
            "html",
            "word",
            "jpg",
            "bmp",
            "all"});
			this.comboBox1.Location = new System.Drawing.Point(139, 57);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(142, 32);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
			this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(37, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "SearchMask";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contains Name";
			// 
			// txbFileNameContains
			// 
			this.txbFileNameContains.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbFileNameContains.Location = new System.Drawing.Point(139, 103);
			this.txbFileNameContains.Name = "txbFileNameContains";
			this.txbFileNameContains.Size = new System.Drawing.Size(142, 32);
			this.txbFileNameContains.TabIndex = 4;
			this.txbFileNameContains.TextChanged += new System.EventHandler(this.txbFileNameContains_TextChanged);
			this.txbFileNameContains.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(4, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "File Size (Mbyte)";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDown1.Location = new System.Drawing.Point(139, 154);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(142, 32);
			this.numericUpDown1.TabIndex = 6;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblSize);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Location = new System.Drawing.Point(139, 193);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(142, 71);
			this.panel1.TabIndex = 7;
			// 
			// lblSize
			// 
			this.lblSize.AutoSize = true;
			this.lblSize.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSize.Location = new System.Drawing.Point(48, 27);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(18, 24);
			this.lblSize.TabIndex = 8;
			this.lblSize.Text = "1";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(4, 37);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(37, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "<=";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(4, 13);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(37, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = ">=";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(68, 301);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 39);
			this.button1.TabIndex = 8;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(68, 300);
			this.progressBar1.Maximum = 100000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(143, 39);
			this.progressBar1.Step = 1;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 9;
			this.progressBar1.Visible = false;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(103, 270);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(291, 351);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbFileNameContains);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnDirectory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SearchForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
			this.Load += new System.EventHandler(this.SearchForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDirectory;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbFileNameContains;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnCancel;
	}
}