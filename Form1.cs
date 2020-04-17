using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace FindFiles
{
	public  partial class Form1 : Form
	{
		SearchForm searchForm;
	
		public Form1()
		{
			InitializeComponent();

		}

		public void AddPath(List<string> path)
		{
			foreach (var item in path)
			{
				lstbFile.Items.Add(item); 
			}
		}
		public void ClearLstBox()
		{
			lstbFile.Items.Clear();
			lstbFile.Update();
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			searchForm = new SearchForm();
			searchForm.Owner = this;
			searchForm.Show();
		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			try
			{
				if (lstbFile.SelectedIndex != ListBox.NoMatches)
				{
					Process.Start(lstbFile.SelectedItem.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lstbFile_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			btnOpenFile_Click(this, null);
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
		}

	
	}
}
