/*
'
' Copyright (C) 2009 Peter Gill <peter@majorsilence.com>
' 
' This file is part of LowerCaseExtensions.
'
' LowerCaseExtensions is free software; you can redistribute it and/or modify
' it under the terms of the GNU Lesser General Public License as published by
' the Free Software Foundation; either version 3 of the License, or
' (at your option) any later version.

' LowerCaseExtensions is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU Lesser General Public License for more details.

' You should have received a copy of the GNU Lesser General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LowerCaseExtensions
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private List<string> photoList;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListView1DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListView1DragEnter);

			
			photoList = new List<string>();
		}
		
		
		private void LoadPhotosIntoListView()
		{
			
			if (this.photoList.Count <=0 )
			{
				MessageBox.Show("Please add photos to Lowercase");
				return;
			}
			toolStripStatusLabel1.Text = "Lowercase Your Extenstions";
			toolStripStatusLabel1.ForeColor = Color.Black;
			
			//http://ondotnet.com/pub/a/dotnet/2002/10/28/listview.html?page=2
			listView1.Items.Clear();
			List<ListViewItem> itemList = new List<ListViewItem>();
			
			foreach (string str in photoList)
			{
				ListViewItem item = new ListViewItem(System.IO.Path.GetFileName(str));
				item.SubItems.Add(str);
				itemList.Add(item);
			}
			listView1.Items.AddRange(itemList.ToArray());
		}
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult results = openFileDialog1.ShowDialog();
			if (results == DialogResult.Cancel)
			{		
				return;
			}
			else if(results == DialogResult.OK)
			{
				
				foreach (string str in openFileDialog1.FileNames)
				{			
					this.AddPhotoToString(str);
				}
				LoadPhotosIntoListView();
			}
			else
			{
				MessageBox.Show("Something unexpected has happened.");
			}
		}
		
		void BtnLowercaseClick(object sender, EventArgs e)
		{
			
			if (this.photoList.Count <=0 )
			{
				MessageBox.Show("Please add photos to Lowercase");
				return;
			}
			
			foreach (string str in photoList)
			{
				System.IO.FileInfo fileInfo = new System.IO.FileInfo(str);
				string ext = fileInfo.Extension;
				
				if (ext.ToLower() != ext )
				{
					if (fileInfo.Exists)
					{
						//MessageBox.Show(string.Format("{0} --- {1}", ext, str));
						string dest = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(str),
						                                     System.IO.Path.GetFileNameWithoutExtension(str) + ext.ToLower());
						
						System.IO.File.Move(str, dest);
					}
				}
				
			}
			this.photoList.Clear();
			this.listView1.Items.Clear();
			toolStripStatusLabel1.Text = "Finished";
			toolStripStatusLabel1.ForeColor = Color.Red;
		}
		
		void ListView1DragEnter(object sender, DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}

		}
		
		void ListView1DragDrop(object sender, DragEventArgs e)
		{
			string[] s = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
			int i;
			for(i = 0; i < s.Length; i++)
			{
				this.AddPhotoToString(s[i]);
			}
			
			this.LoadPhotosIntoListView();
		}
		
		private void AddPhotoToString(string str)
		{
			bool keep = true;
			foreach(string s in this.photoList)
			{
				if (str == s)
				{
					keep = false;
				}
			}
			if (keep == true)
			{
				this.photoList.Add(str);
			}
		}
	}
	
}
