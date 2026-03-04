using System.Drawing.Printing;

namespace AwfulDocumentViewer
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Panel buttonsPanel;
			Label label1;
			Label label3;
			Label label2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			btnOpenImageView = new Button();
			btnOpenFile = new Button();
			btnPrintPreview = new Button();
			btnPrintBy = new Button();
			btnPageSetup = new Button();
			printDocument1 = new PrintDocument();
			pageSetupDialog1 = new PageSetupDialog();
			printDialog1 = new PrintDialog();
			printPreviewDialog1 = new PrintPreviewDialog();
			openFileDialog1 = new OpenFileDialog();
			splitContainer = new SplitContainer();
			btnPrintFromPreview = new Button();
			chkAntiAlias = new CheckBox();
			numericZoom = new NumericUpDown();
			numericColumns = new NumericUpDown();
			numericRows = new NumericUpDown();
			printPreviewControl1 = new PrintPreviewControl();
			buttonsPanel = new Panel();
			label1 = new Label();
			label3 = new Label();
			label2 = new Label();
			buttonsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
			splitContainer.Panel1.SuspendLayout();
			splitContainer.Panel2.SuspendLayout();
			splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericZoom).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericColumns).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericRows).BeginInit();
			SuspendLayout();
			// 
			// buttonsPanel
			// 
			buttonsPanel.BackColor = SystemColors.Control;
			buttonsPanel.Controls.Add(btnOpenImageView);
			buttonsPanel.Controls.Add(btnOpenFile);
			buttonsPanel.Controls.Add(btnPrintPreview);
			buttonsPanel.Controls.Add(btnPrintBy);
			buttonsPanel.Controls.Add(btnPageSetup);
			buttonsPanel.Dock = DockStyle.Top;
			buttonsPanel.Location = new Point(0, 0);
			buttonsPanel.Name = "buttonsPanel";
			buttonsPanel.Padding = new Padding(6);
			buttonsPanel.Size = new Size(553, 42);
			buttonsPanel.TabIndex = 1;
			// 
			// btnOpenImageView
			// 
			btnOpenImageView.Dock = DockStyle.Left;
			btnOpenImageView.Location = new Point(406, 6);
			btnOpenImageView.Name = "btnOpenImageView";
			btnOpenImageView.Size = new Size(112, 30);
			btnOpenImageView.TabIndex = 4;
			btnOpenImageView.Text = "Open Image View";
			btnOpenImageView.UseVisualStyleBackColor = true;
			btnOpenImageView.Click += btnOpenImageView_Click;
			// 
			// btnOpenFile
			// 
			btnOpenFile.Dock = DockStyle.Left;
			btnOpenFile.Location = new Point(306, 6);
			btnOpenFile.Name = "btnOpenFile";
			btnOpenFile.Size = new Size(100, 30);
			btnOpenFile.TabIndex = 3;
			btnOpenFile.Text = "Open File";
			btnOpenFile.UseVisualStyleBackColor = true;
			btnOpenFile.Click += btnOpenFile_Click;
			// 
			// btnPrintPreview
			// 
			btnPrintPreview.Dock = DockStyle.Left;
			btnPrintPreview.Location = new Point(206, 6);
			btnPrintPreview.Name = "btnPrintPreview";
			btnPrintPreview.Size = new Size(100, 30);
			btnPrintPreview.TabIndex = 2;
			btnPrintPreview.Text = "Print Preview";
			btnPrintPreview.UseVisualStyleBackColor = true;
			btnPrintPreview.Click += btnPrintPreview_Click;
			// 
			// btnPrintBy
			// 
			btnPrintBy.Dock = DockStyle.Left;
			btnPrintBy.Location = new Point(106, 6);
			btnPrintBy.Name = "btnPrintBy";
			btnPrintBy.Size = new Size(100, 30);
			btnPrintBy.TabIndex = 1;
			btnPrintBy.Text = "Print by";
			btnPrintBy.UseVisualStyleBackColor = true;
			btnPrintBy.Click += btnPrintBy_Click;
			// 
			// btnPageSetup
			// 
			btnPageSetup.Dock = DockStyle.Left;
			btnPageSetup.Location = new Point(6, 6);
			btnPageSetup.Name = "btnPageSetup";
			btnPageSetup.Size = new Size(100, 30);
			btnPageSetup.TabIndex = 0;
			btnPageSetup.Text = "Page Setup";
			btnPageSetup.UseVisualStyleBackColor = true;
			btnPageSetup.Click += btnPageSetup_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(7, 8);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "Rows:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 66);
			label3.Name = "label3";
			label3.Size = new Size(84, 15);
			label3.TabIndex = 4;
			label3.Text = "Magnification:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 37);
			label2.Name = "label2";
			label2.Size = new Size(58, 15);
			label2.TabIndex = 2;
			label2.Text = "Columns:";
			// 
			// printDocument1
			// 
			printDocument1.BeginPrint += printDocument1_BeginPrint;
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// pageSetupDialog1
			// 
			pageSetupDialog1.Document = printDocument1;
			// 
			// printDialog1
			// 
			printDialog1.AllowSomePages = true;
			printDialog1.Document = printDocument1;
			printDialog1.UseEXDialog = true;
			// 
			// printPreviewDialog1
			// 
			printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
			printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
			printPreviewDialog1.ClientSize = new Size(400, 300);
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.Enabled = true;
			printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
			printPreviewDialog1.Name = "printPreviewDialog1";
			printPreviewDialog1.Visible = false;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Text Files|*.txt";
			// 
			// splitContainer
			// 
			splitContainer.Dock = DockStyle.Fill;
			splitContainer.Location = new Point(0, 42);
			splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			splitContainer.Panel1.BackColor = SystemColors.Control;
			splitContainer.Panel1.Controls.Add(btnPrintFromPreview);
			splitContainer.Panel1.Controls.Add(chkAntiAlias);
			splitContainer.Panel1.Controls.Add(numericZoom);
			splitContainer.Panel1.Controls.Add(label3);
			splitContainer.Panel1.Controls.Add(numericColumns);
			splitContainer.Panel1.Controls.Add(label2);
			splitContainer.Panel1.Controls.Add(numericRows);
			splitContainer.Panel1.Controls.Add(label1);
			splitContainer.Panel1.Padding = new Padding(7);
			// 
			// splitContainer.Panel2
			// 
			splitContainer.Panel2.Controls.Add(printPreviewControl1);
			splitContainer.Panel2.Padding = new Padding(0, 0, 6, 6);
			splitContainer.Size = new Size(553, 408);
			splitContainer.SplitterDistance = 221;
			splitContainer.TabIndex = 2;
			// 
			// btnPrintFromPreview
			// 
			btnPrintFromPreview.Dock = DockStyle.Bottom;
			btnPrintFromPreview.Location = new Point(7, 371);
			btnPrintFromPreview.Name = "btnPrintFromPreview";
			btnPrintFromPreview.Size = new Size(207, 30);
			btnPrintFromPreview.TabIndex = 7;
			btnPrintFromPreview.Text = "Print";
			btnPrintFromPreview.UseVisualStyleBackColor = true;
			btnPrintFromPreview.Click += btnPrint_Click;
			// 
			// chkAntiAlias
			// 
			chkAntiAlias.AutoSize = true;
			chkAntiAlias.Location = new Point(7, 105);
			chkAntiAlias.Name = "chkAntiAlias";
			chkAntiAlias.Size = new Size(76, 19);
			chkAntiAlias.TabIndex = 6;
			chkAntiAlias.Text = "Anti Alias";
			chkAntiAlias.UseVisualStyleBackColor = true;
			chkAntiAlias.CheckedChanged += chkAntiAlias_CheckedChanged;
			// 
			// numericZoom
			// 
			numericZoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			numericZoom.Increment = new decimal(new int[] { 25, 0, 0, 0 });
			numericZoom.Location = new Point(106, 64);
			numericZoom.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
			numericZoom.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
			numericZoom.Name = "numericZoom";
			numericZoom.Size = new Size(108, 23);
			numericZoom.TabIndex = 5;
			numericZoom.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// numericColumns
			// 
			numericColumns.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			numericColumns.Location = new Point(106, 35);
			numericColumns.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
			numericColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericColumns.Name = "numericColumns";
			numericColumns.Size = new Size(108, 23);
			numericColumns.TabIndex = 3;
			numericColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericColumns.ValueChanged += numericColumns_ValueChanged;
			// 
			// numericRows
			// 
			numericRows.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			numericRows.Location = new Point(106, 6);
			numericRows.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
			numericRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericRows.Name = "numericRows";
			numericRows.Size = new Size(108, 23);
			numericRows.TabIndex = 1;
			numericRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericRows.ValueChanged += numericRows_ValueChanged;
			// 
			// printPreviewControl1
			// 
			printPreviewControl1.Dock = DockStyle.Fill;
			printPreviewControl1.Location = new Point(0, 0);
			printPreviewControl1.Name = "printPreviewControl1";
			printPreviewControl1.Size = new Size(322, 402);
			printPreviewControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 450);
			Controls.Add(splitContainer);
			Controls.Add(buttonsPanel);
			Name = "MainForm";
			Text = "Awful Document Viewer";
			buttonsPanel.ResumeLayout(false);
			splitContainer.Panel1.ResumeLayout(false);
			splitContainer.Panel1.PerformLayout();
			splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
			splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)numericZoom).EndInit();
			((System.ComponentModel.ISupportInitialize)numericColumns).EndInit();
			((System.ComponentModel.ISupportInitialize)numericRows).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PrintDocument printDocument1;
		private PageSetupDialog pageSetupDialog1;
		private PrintDialog printDialog1;
		private PrintPreviewDialog printPreviewDialog1;
		private OpenFileDialog openFileDialog1;
		private Button btnPageSetup;
		private Button btnOpenFile;
		private Button btnPrintPreview;
		private Button btnPrintBy;
		private SplitContainer splitContainer;
		private NumericUpDown numericRows;
		private NumericUpDown numericColumns;
		private PrintPreviewControl printPreviewControl1;
		private NumericUpDown numericZoom;
		private CheckBox chkAntiAlias;
		private Button btnPrintFromPreview;
		private Button btnOpenImageView;
	}
}
