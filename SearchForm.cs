using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FindFiles
{
	public partial class SearchForm : Form
	{
		//поля и свойства делал сначало чтобы получать данные отсюда в основной форме
		//но потом придумал другую реализацию, а поля и свойства решил все же оставить для внутреннего использования
		//+есть возможность все же вытягивать отсюда данные не нарушая инкапсуляцию
		string folder_name;
		string serach_mask;
		string contains_name;
		decimal file_size;
		int file_coorse;
		Form1 form1;
		List<string> search_info;
	
		public string Folder_name { get => folder_name; private set => folder_name = value; }
		public string Serach_mask { get => serach_mask; private set => serach_mask = value; }
		public decimal File_size { get => file_size; private set => file_size = value; }
		public int File_coorse { get => file_coorse; private set => file_coorse = value; }
		public string Contains_name { get => contains_name; private set => contains_name = value; }

		public SearchForm()
		{
			InitializeComponent();
			folder_name = "";
			serach_mask = "";
			contains_name = "";
			file_size = 0;
			file_coorse = 0;
			search_info = new List<string>();

		}

		private void SearchForm_Load(object sender, EventArgs e)
		{
			form1 = this.Owner as Form1;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			lblSize.Text = numericUpDown1.Value.ToString();
			File_size = numericUpDown1.Value;
			if (numericUpDown1.Value > numericUpDown1.Maximum)
			{
				MessageBox.Show("Values its too big, max = 100000", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				File_size = 0;
				lblSize.Text = "0";
				numericUpDown1.Value = 0;
				return;
			}
			
		}

		private void comboBox1_Leave(object sender, EventArgs e)
		{
			if (comboBox1.Text.Length > 0)
			{
				serach_mask = comboBox1.Text;
				comboBox1.SelectedItem = comboBox1.Text;
				if (!comboBox1.Items.Contains(comboBox1.Text)) comboBox1.Items.Add(comboBox1.Text);
			}
			else MessageBox.Show("String is empty or Position already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}

		private void comboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					if (comboBox1.Text.Length > 0)
					{
						serach_mask = comboBox1.Text;
						comboBox1.SelectedItem = comboBox1.Text;
						if (!comboBox1.Items.Contains(comboBox1.Text)) comboBox1.Items.Add(comboBox1.Text);
						MessageBox.Show("Position Added");
					}
					else MessageBox.Show("String is empty or Position already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			contains_name = txbFileNameContains.Text;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
		
			file_coorse = 0;
			lblSize.Text = numericUpDown1.Value.ToString();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			file_coorse = 1;
			lblSize.Text = numericUpDown1.Value.ToString();
		}

		private void btnDirectory_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				folder_name = folderBrowserDialog1.SelectedPath;
			}
		}



		void StartSearching(string path)
		{
			try
			{
				if (backgroundWorker1.CancellationPending) return;
				foreach (var item in Directory.GetFileSystemEntries(path))
				{
					if (File.Exists(item))
					{
						FileInfo fileInfo = new FileInfo(item);
						if (fileInfo.Extension.Contains(serach_mask) || serach_mask == "all")
						{
							bool size = false;
							switch (file_coorse)
							{
								case 1: if (fileInfo.Length  <= numericUpDown1.Value* 1048576)
										size = true;
									else 
										size = false;
									break;
								case 0:
									if (fileInfo.Length  >= numericUpDown1.Value * 1048576)
										size = true;
									else
										size = false;
									break;
							}
							if (size)
							{
				
								if (contains_name.Length > 0)
								{
									if (fileInfo.Name.ToLower().Contains(contains_name.ToLower()))
									{
										search_info.Add(item);								

									}
								}
								else
								{
									search_info.Add(item);					

								}
							}
						}
						
					}
					StartSearching(item);
				}
			}
			catch(Exception ex)
			{
				//екзепшион не реализую специально
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (serach_mask.Length < 1 || folder_name.Length < 1)
			{
				MessageBox.Show("Choose file derectory for search and Mask", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				if (radioButton2.Checked && numericUpDown1.Value == 0)
				{
					MessageBox.Show("Change value of size files!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (search_info.Count > 0) search_info.Clear();							
				if (MessageBox.Show("Clear result List?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					form1.ClearLstBox();
				}
				progressBar1.Visible = true;
				btnCancel.Visible = true;
				backgroundWorker1.RunWorkerAsync();				
			}
		}

	

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{		
			StartSearching(folder_name);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			progressBar1.Visible = false;
			btnCancel.Visible = false;
			if (search_info.Count > 0) form1.AddPath(search_info);
			else MessageBox.Show("No results", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txbFileNameContains_TextChanged(object sender, EventArgs e)
		{
			contains_name = txbFileNameContains.Text;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}

		private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (backgroundWorker1.IsBusy)
			{
				backgroundWorker1.CancelAsync();
			}
		}

		private void numericUpDown1_Scroll(object sender, ScrollEventArgs e)
		{
			numericUpDown1_ValueChanged(this, null);
		}

	
	}
}
