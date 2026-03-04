namespace AwfulDocumentViewer
{
	partial class ImageViewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewForm));
			openFileDialog1 = new OpenFileDialog();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			printPreviewDialog1 = new PrintPreviewDialog();
			panel1 = new Panel();
			btnPrint = new Button();
			btnPrintPreview = new Button();
			btnOpenImage = new Button();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff)|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff|All files (*.*)|*.*";
			// 
			// printDocument1
			// 
			printDocument1.PrintPage += printDocument1_PrintPage;
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
			// panel1
			// 
			panel1.Controls.Add(btnPrint);
			panel1.Controls.Add(btnPrintPreview);
			panel1.Controls.Add(btnOpenImage);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(6, 6);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(0, 0, 0, 6);
			panel1.Size = new Size(464, 36);
			panel1.TabIndex = 0;
			// 
			// btnPrint
			// 
			btnPrint.Dock = DockStyle.Left;
			btnPrint.Location = new Point(200, 0);
			btnPrint.Name = "btnPrint";
			btnPrint.Size = new Size(100, 30);
			btnPrint.TabIndex = 2;
			btnPrint.Text = "Print";
			btnPrint.UseVisualStyleBackColor = true;
			btnPrint.Click += btnPrint_Click;
			// 
			// btnPrintPreview
			// 
			btnPrintPreview.Dock = DockStyle.Left;
			btnPrintPreview.Location = new Point(100, 0);
			btnPrintPreview.Name = "btnPrintPreview";
			btnPrintPreview.Size = new Size(100, 30);
			btnPrintPreview.TabIndex = 1;
			btnPrintPreview.Text = "Print Preview";
			btnPrintPreview.UseVisualStyleBackColor = true;
			btnPrintPreview.Click += btnPrintPreview_Click;
			// 
			// btnOpenImage
			// 
			btnOpenImage.Dock = DockStyle.Left;
			btnOpenImage.Location = new Point(0, 0);
			btnOpenImage.Name = "btnOpenImage";
			btnOpenImage.Size = new Size(100, 30);
			btnOpenImage.TabIndex = 0;
			btnOpenImage.Text = "Open image";
			btnOpenImage.UseVisualStyleBackColor = true;
			btnOpenImage.Click += btnOpenImage_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Location = new Point(6, 42);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(464, 232);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// ImageViewForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(476, 280);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Name = "ImageViewForm";
			Padding = new Padding(6);
			Text = "ImageViewForm";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private OpenFileDialog openFileDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
		private Panel panel1;
		private Button btnOpenImage;
		private Button btnPrintPreview;
		private Button btnPrint;
		private PictureBox pictureBox1;
	}
}