using System.Drawing.Printing;

namespace AwfulDocumentViewer;

public partial class ImageViewForm : Form
{
	private Image? currentImage = null;
	private string currentFileName = string.Empty;

	public ImageViewForm()
	{
		InitializeComponent();
	}

	private void btnOpenImage_Click(object sender, EventArgs e)
	{
		if (openFileDialog1.ShowDialog() == DialogResult.OK)
		{
			try
			{
				currentImage = Image.FromFile(openFileDialog1.FileName);
				pictureBox1.Image = currentImage;
				currentFileName = openFileDialog1.FileName;
				Text = "Image View - " + Path.GetFileName(currentFileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при открытии изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

	private void btnPrintPreview_Click(object sender, EventArgs e)
	{
		if (currentImage == null)
		{
			MessageBox.Show("Сперва откройте изображение.", btnPrintPreview.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}
		printPreviewDialog1.Document = printDocument1;
		printPreviewDialog1.ShowDialog();
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		if (currentImage == null)
		{
			MessageBox.Show("Сперва откройте изображение.", btnPrint.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		using (var pd = new PrintDialog() { Document = printDocument1 })
			if (pd.ShowDialog() == DialogResult.OK)

		printDocument1.Print();
	}

	private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		if (currentImage == null) return;

		RectangleF printableArea = e.MarginBounds;

		float imageWidth = currentImage.Width;
		float imageHeight = currentImage.Height;
		float ratioImage = imageWidth / imageHeight;
		float ratioPrintable = printableArea.Width / printableArea.Height;

		RectangleF destRect;

		if (ratioImage > ratioPrintable)
		{
			float destWidth = printableArea.Width;
			float destHeight = destWidth / ratioImage;
			destRect = new RectangleF(
				printableArea.Left,
				printableArea.Top + (printableArea.Height - destHeight) / 2,
				destWidth,
				destHeight);
		}
		else
		{
			float destHeight = printableArea.Height;
			float destWidth = destHeight * ratioImage;
			destRect = new RectangleF(
				printableArea.Left + (printableArea.Width - destWidth) / 2,
				printableArea.Top,
				destWidth,
				destHeight);
		}

		e.Graphics?.DrawImage(currentImage, destRect);
		e.HasMorePages = false;
	}
}