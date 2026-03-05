namespace PracticalN5
{
	partial class SummOfNumsInFileForm
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
			btnOpenFileAndCalc = new Button();
			lblNumbersSumm = new Label();
			SuspendLayout();
			// 
			// btnOpenFileAndCalc
			// 
			btnOpenFileAndCalc.Location = new Point(12, 36);
			btnOpenFileAndCalc.Name = "btnOpenFileAndCalc";
			btnOpenFileAndCalc.Size = new Size(111, 50);
			btnOpenFileAndCalc.TabIndex = 0;
			btnOpenFileAndCalc.Text = "Выбрать файл и посчитать";
			btnOpenFileAndCalc.UseVisualStyleBackColor = true;
			btnOpenFileAndCalc.Click += btnOpenFileAndCalc_Click;
			// 
			// lblNumbersSumm
			// 
			lblNumbersSumm.AutoSize = true;
			lblNumbersSumm.Location = new Point(129, 54);
			lblNumbersSumm.Name = "lblNumbersSumm";
			lblNumbersSumm.Size = new Size(131, 15);
			lblNumbersSumm.TabIndex = 1;
			lblNumbersSumm.Text = "Сумма чисел в файле:";
			// 
			// SummOfNumsInFileForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(409, 124);
			Controls.Add(lblNumbersSumm);
			Controls.Add(btnOpenFileAndCalc);
			Name = "SummOfNumsInFileForm";
			Text = "SummOfNumsInFileForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOpenFileAndCalc;
		private Label lblNumbersSumm;
	}
}