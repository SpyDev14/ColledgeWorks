using System.Text.RegularExpressions;

namespace PracticalN5;

public partial class SummOfNumsInFileForm : Form
{
	const string NUMERICS_PATTERN = @"-?\b\d+[,.]?\d*\b";
	readonly string labelPrefix;

	public SummOfNumsInFileForm()
	{
		InitializeComponent();
		labelPrefix = lblNumbersSumm.Text.Trim();
	}

	private void btnOpenFileAndCalc_Click(object sender, EventArgs e)
	{
		var dialog = new OpenFileDialog() { Filter = Program.TEXT_FILE_FILTER };
		if (dialog.ShowDialog() != DialogResult.OK) return;

		string fileText;
		using (var sr = new StreamReader(dialog.FileName))
			fileText = sr.ReadToEnd();

		var matches = Regex.Matches(fileText, NUMERICS_PATTERN);

		double summ = 0;
		//summ = matches
		//	.Select(x => x.Value)
		//	.Select(x => double.TryParse(x.Replace('.', ','), out double value) ? value : 0)
		//	.Sum();

		foreach (Match match in matches)
		{
			string valueStr = match.Value.Replace('.', ',');
			summ += double.TryParse(valueStr, out double value) ? value : 0;
		}

		lblNumbersSumm.Text = $"{labelPrefix} {summ.ToString()}";
	}
}
