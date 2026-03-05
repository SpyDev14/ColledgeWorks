namespace MathQuiz;

public partial class MainForm : Form
{
	const int QUIZ_SECONDS = 30;
	const int RND_NUMS_RANGE = 9; // Without negatives

	Random rnd = new Random();
	bool _ignoreValueChanged;
	int RemainingSeconds
	{
		get => field;
		set
		{
			if (value < 0)
				EndQuiz(false);
			else
			{
				lblTime.Text = value.ToString();
				field = value;
			}
		}
	}

	int LeftNum
	{
		get => field != 0 ? field : -1;
		set
		{
			lblSumLOp.Text = value.ToString();
			lblSubLOp.Text = value.ToString();
			lblMulLOp.Text = value.ToString();
			lblDivLOp.Text = value.ToString();
			field = value;
		}
	}
	int RightNum
	{
		get => field != 0 ? field : 1;
		set
		{
			lblSumROp.Text = value.ToString();
			lblSubROp.Text = value.ToString();
			lblMulROp.Text = value.ToString();
			lblDivROp.Text = value.ToString();
			field = value;
		}
	}

	Label[] leftNumLabels;
	Label[] rightNumLabels;
	(NumericUpDown field, Predicate<int> checkIsRight)[] numInputsAndValidChecker;

	public MainForm()
	{
		InitializeComponent();

		timer.Stop();
		timer.Tick += (s, e) => RemainingSeconds--;
		timer.Interval = 1000;

		leftNumLabels = [
			lblSumLOp, lblSubLOp,
			lblMulLOp, lblDivLOp,
		];

		rightNumLabels = [
			lblSumROp, lblSubROp,
			lblMulROp, lblDivROp,
		];

		numInputsAndValidChecker = [
			(numInputSum, v => v == LeftNum + RightNum),
			(numInputSub, v => v == LeftNum - RightNum),
			(numInputMul, v => v == LeftNum * RightNum),
			(numInputDiv, v => v == LeftNum / RightNum)
		];

		foreach (var x in numInputsAndValidChecker)
		{
			x.field.Enabled = false;
			x.field.ValueChanged += AnyField_ValueChanged;
		}
		lblTime.Text = QUIZ_SECONDS.ToString();
	}

	void SetInputsEnable(bool enable)
	{
		foreach (var x in numInputsAndValidChecker)
			x.field.Enabled = enable;
	}

	void StartQuiz()
	{
		btnStart.Enabled = false;

		MessageBox.Show(
			"ВЫ БЫЛИ ВЫБРАНЫ ДЛЯ ТЕСТИРОВАНЯИ НА УМСТВЕННЫЙ СПОСОБНОСТИ ВЕЛИКИЙ ПАРТИЯ КИТАЙ!! " +
			"ДОКАЖИТЕ, ЧТО УМЕЕТЕ СКЛАДЫВАТЬ 2 + 2, ИЛИ ВЕЛИКИЙ ПАРТИЯ КИТАЙ РАЗОЧАРУЕТСЯ В ВАС! " +
			$"ВЫ ЖЕ НЕ ХОТИТЕ РАЗОЧАРОВАТЬ ВЕЛИКИЙ ТОВАРИЩ СИ?! ВЕРНО?!!! У ВАС ЕСТЬ {QUIZ_SECONDS} " +
			"СЕКУНД. ВПЕРЁД!!!",
			"ТЕСТИРОВАНИЕ НА УМСТВЕННЫЕ СПОСОБНОСТИ",
			MessageBoxButtons.OK,
			MessageBoxIcon.Information
		);


		LeftNum = rnd.Next(-RND_NUMS_RANGE, RND_NUMS_RANGE);
		RightNum = rnd.Next(-RND_NUMS_RANGE, RND_NUMS_RANGE);

		SetInputsEnable(true);

		lblTime.Text = QUIZ_SECONDS.ToString();
		foreach (var x in numInputsAndValidChecker) x.field.Value = 0;
		RemainingSeconds = QUIZ_SECONDS;
		timer.Start();
	}

	void EndQuiz(bool success)
	{
		timer.Stop();
		SetInputsEnable(false);

		if (!success)
		{
			MessageBox.Show(
				"ВЫ РАЗОЧАРОВАЛИ ВЕЛИКИЙ ПАРТИЯ КИТАЙ!! ВЫ ОТПРАВЛЯЕТЕСЬ НА ПРОЦЕДУРЫ.",
				"ВЫ ПРОВАЛИЛИ!!!",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation
			);
			MessageBox.Show("Правильные ответы отображены на доске.", Text);
			_ignoreValueChanged = true;
			numInputSum.Value = LeftNum + RightNum;
			numInputSub.Value = LeftNum - RightNum;
			numInputMul.Value = LeftNum * RightNum;
			numInputDiv.Value = LeftNum / RightNum;
			_ignoreValueChanged = false;
		}
		else
		{
			MessageBox.Show(
				"ВЫ ПРОШЛИ! ВЕЛИКИЙ ПАРТИЯ КИТАЙ ВЫДАЁТ ВАМ ТАЛОН НА ДОПОЛНИТЕЛЬНЫЙ МИСКА ГОРЯЧИЙ РИС.",
				"УСПЕШНО",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		btnStart.Enabled = true;
	}

	void AnyField_ValueChanged(object? o, EventArgs e)
	{
		if (_ignoreValueChanged) return;

		bool allAnswersRight = numInputsAndValidChecker
			.Select(x => x.checkIsRight(Convert.ToInt32(x.field.Value)))
			.All(x => x);

		if (allAnswersRight)
			EndQuiz(true);
	}

	private void btnStart_Click(object sender, EventArgs e)
		=> StartQuiz();
}
