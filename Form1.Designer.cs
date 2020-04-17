namespace FindFiles
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.lstbFile = new System.Windows.Forms.ListBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImage = global::FindFiles.Properties.Resources._31828760_foto_eines_alten_tierhaut_pergament_zerknittert_grobkörnigen_gesprenkelt_ockergelb_vignette_grunge_text;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.Location = new System.Drawing.Point(18, 22);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(112, 42);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "SearchFiles";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.BackgroundImage = global::FindFiles.Properties.Resources.depositphotos_102161124_stock_photo_old_paper_background_with_vintage;
			this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnOpenFile.Location = new System.Drawing.Point(140, 22);
			this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(112, 42);
			this.btnOpenFile.TabIndex = 1;
			this.btnOpenFile.Text = "OpenFile";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
		
			// 
			// lstbFile
			// 
			this.lstbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstbFile.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lstbFile.FormattingEnabled = true;
			this.lstbFile.HorizontalScrollbar = true;
			this.lstbFile.ItemHeight = 24;
			this.lstbFile.Location = new System.Drawing.Point(18, 74);
			this.lstbFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.lstbFile.Name = "lstbFile";
			this.lstbFile.Size = new System.Drawing.Size(736, 340);
			this.lstbFile.TabIndex = 2;
			this.lstbFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbFile_MouseDoubleClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackgroundImage = global::FindFiles.Properties.Resources._1;
			this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(774, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// toolTip1
			// 
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "sdfsdf";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FindFiles.Properties.Resources._1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(774, 461);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lstbFile);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.btnSearch);
			this.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "lstbFile";
			this.Text = "FindFiles";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.ListBox lstbFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

