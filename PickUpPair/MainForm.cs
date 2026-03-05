using System.Collections.Immutable;
using System.Diagnostics;

namespace PickUpPair;

public partial class MainForm : Form
{
	const int WAIT_INTERVAL = 750;

	Random rnd = new();
	static readonly ImmutableArray<char> icons = ['!', 'N', ',', 'k', 'b', 'v', 'w', 'z'];
	static readonly Color IconsColor = Color.Black;

	Label? firstClicked, secondClicked;

	public MainForm()
	{
		InitializeComponent();
		AssingIconsToSquares();

		timer.Interval = WAIT_INTERVAL;

		Debug.Assert(icons.Length == board.Controls.Count / 2);
	}

	void HideLabel(Label? lbl)
	{
		if (lbl is null) return;
		lbl.ForeColor = board.BackColor;
		lbl.Enabled = true;
	}

	void ShowLabel(Label? lbl)
	{
		if (lbl is null) return;
		lbl.ForeColor = IconsColor;
		lbl.Enabled = false;
	}

	void AssingIconsToSquares()
	{
		var iconsToAssign = icons
			.Concat(icons)
			.Select(x => x.ToString())
			.ToList();

		foreach (var lbl in board.Controls.OfType<Label>())
		{
			int iconIndex = rnd.Next(iconsToAssign.Count);
			lbl.Text = iconsToAssign[iconIndex];
			iconsToAssign.RemoveAt(iconIndex);
			HideLabel(lbl);
		}
	}

	void AnyLabel_Click(object sender, EventArgs e)
	{
		if (sender is not Label lbl) return;

		if (timer.Enabled) return;
		if (!lbl.Enabled) return;

		if (firstClicked == null)
		{
			firstClicked = lbl;
			ShowLabel(lbl);
			return;
		}

		if (secondClicked == null && lbl != firstClicked)
		{
			secondClicked = lbl;
			ShowLabel(lbl);

			if (firstClicked.Text == secondClicked.Text)
			{
				firstClicked = null;
				secondClicked = null;

				CheckForWin();
			}
			else
				timer.Start();
		}

		void CheckForWin()
		{
			bool allOpen = board.Controls.OfType<Label>().All(l => !l.Enabled);
			if (!allOpen) return;

			MessageBox.Show("Вы выиграли! Все карточки раскрыты.");

			timer.Stop();
			AssingIconsToSquares();
			firstClicked = null;
			secondClicked = null;
		}
	}

	void timer_Tick(object sender, EventArgs e)
	{
		timer.Stop();

		HideLabel(firstClicked);
		HideLabel(secondClicked);

		firstClicked = null;
		secondClicked = null;
	}

	void MainForm_ResizeBegin(object sender, EventArgs e) => board.SuspendLayout();
	void MainForm_ResizeEnd(object sender, EventArgs e) => board.ResumeLayout();
}