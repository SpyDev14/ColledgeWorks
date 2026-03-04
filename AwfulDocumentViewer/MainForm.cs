using System.Drawing.Printing;

namespace AwfulDocumentViewer;

public partial class MainForm : Form
{
	readonly string AppName;

	private List<string> fileLines = new List<string>();
	private int currentLineIndex = 0;
	private readonly Font printFont = new Font("Arial", 10);


	public MainForm()
	{
		InitializeComponent();

		AppName = Text;
	}

	private void btnPageSetup_Click(object sender, EventArgs e)
	{
		pageSetupDialog1.ShowDialog();
	}

	private void btnPrintBy_Click(object sender, EventArgs e)
	{
		if (printDialog1.ShowDialog() == DialogResult.OK)
			printDocument1.Print();
	}

	private void btnPrintPreview_Click(object sender, EventArgs e)
	{
		printPreviewControl1.Document = printDocument1;
		printPreviewControl1.Invalidate();
	}

	private void btnOpenFile_Click(object sender, EventArgs e)
	{
		if (openFileDialog1.ShowDialog() == DialogResult.OK)
		{
			fileLines = File.ReadAllLines(openFileDialog1.FileName).ToList();
			Text = $"{AppName} - " + Path.GetFileName(openFileDialog1.FileName);
		}
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		printDocument1.Print();
	}

	private void numericRows_ValueChanged(object sender, EventArgs e)
	{
		printPreviewControl1.Rows = (int)numericRows.Value;
	}

	private void numericColumns_ValueChanged(object sender, EventArgs e)
	{
		printPreviewControl1.Columns = (int)numericColumns.Value;
	}

	private void numericZoom_ValueChanged(object sender, EventArgs e)
	{
		printPreviewControl1.Zoom = (double)numericZoom.Value / 100;
	}

	private void chkAntiAlias_CheckedChanged(object sender, EventArgs e)
	{
		printPreviewControl1.UseAntiAlias = chkAntiAlias.Checked;
	}

	private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
	{
		currentLineIndex = 0;
	}

	private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		if (fileLines == null || fileLines.Count == 0)
		{
			e.HasMorePages = false;
			return;
		}
		if (e.Graphics == null)
			return;

		Font font = printFont;
		float leftMargin = e.MarginBounds.Left;
		float topMargin = e.MarginBounds.Top;
		float lineHeight = font.GetHeight(e.Graphics);
		float yPos = topMargin;
		int linesPerPage = (int)(e.MarginBounds.Height / lineHeight);

		int lineCount = 0;
		while (lineCount < linesPerPage && currentLineIndex < fileLines.Count)
		{
			string line = fileLines[currentLineIndex];
			e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos);
			yPos += lineHeight;
			currentLineIndex++;
			lineCount++;
		}

		e.HasMorePages = (currentLineIndex < fileLines.Count);
	}

	private void btnOpenImageView_Click(object sender, EventArgs e)
	{
		(new ImageViewForm()).Show();
	}
}