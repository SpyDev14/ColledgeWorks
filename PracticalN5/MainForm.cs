using System.Text;

namespace PracticalN5;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void btnOpenNumsInFileSummator_Click(object sender, EventArgs e)
		=> new SummOfNumsInFileForm().Show();

	private void btnOpenFile_Click(object sender, EventArgs e)
	{
		var dialog = new OpenFileDialog() { Filter = Program.TEXT_FILE_FILTER };
		if (dialog.ShowDialog() != DialogResult.OK) return;

		using (var sr = new StreamReader(dialog.FileName))
			textBox.Text = sr.ReadToEnd();
	}

	private void btnSaveFile_Click(object sender, EventArgs e)
	{
		var dialog = new SaveFileDialog() { Filter = Program.TEXT_FILE_FILTER };
		if (dialog.ShowDialog() != DialogResult.OK) return;

		var encoding = Encoding.UTF8;
		File.WriteAllText(dialog.FileName, textBox.Text, encoding);
	}
}
