/*
 * Created by SharpDevelop.
 * User: User
 * Date: 07/17/2009
 * Time: 7:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LowerCaseExtensions
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnFileName = new System.Windows.Forms.ColumnHeader();
			this.columnFilePath = new System.Windows.Forms.ColumnHeader();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnLowercase = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(467, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 257);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(467, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(142, 17);
			this.toolStripStatusLabel1.Text = "Lowercase Your Extenstions";
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnFileName,
									this.columnFilePath});
			this.listView1.Location = new System.Drawing.Point(0, 53);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(467, 204);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListView1DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListView1DragEnter);
			// 
			// columnFileName
			// 
			this.columnFileName.Text = "Filename";
			this.columnFileName.Width = 115;
			// 
			// columnFilePath
			// 
			this.columnFilePath.Text = "Filepath";
			this.columnFilePath.Width = 347;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "jpg";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "JPEG Files (*.jpg/*.JPG/*.jpeg/*.JPEG)|*.jpg|PNG Files (*.png)|*.png|All Files (*" +
			".*)|*.*";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.Title = "Select Photos";
			// 
			// btnLowercase
			// 
			this.btnLowercase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btnLowercase.AutoSize = true;
			this.btnLowercase.Location = new System.Drawing.Point(0, 27);
			this.btnLowercase.Name = "btnLowercase";
			this.btnLowercase.Size = new System.Drawing.Size(467, 23);
			this.btnLowercase.TabIndex = 4;
			this.btnLowercase.Text = "Convert to Lowercase";
			this.btnLowercase.UseVisualStyleBackColor = true;
			this.btnLowercase.Click += new System.EventHandler(this.BtnLowercaseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 279);
			this.Controls.Add(this.btnLowercase);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "LowerCaseExtensions";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button btnLowercase;
		private System.Windows.Forms.ColumnHeader columnFilePath;
		private System.Windows.Forms.ColumnHeader columnFileName;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
