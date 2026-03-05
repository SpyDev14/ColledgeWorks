namespace PracticalN5
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
			btnOpenFile = new Button();
			btnSaveFile = new Button();
			textBox = new TextBox();
			btnOpenNumsInFileSummator = new Button();
			SuspendLayout();
			// 
			// btnOpenFile
			// 
			btnOpenFile.Location = new Point(12, 12);
			btnOpenFile.Name = "btnOpenFile";
			btnOpenFile.Size = new Size(113, 48);
			btnOpenFile.TabIndex = 0;
			btnOpenFile.Text = "Открыть файл";
			btnOpenFile.UseVisualStyleBackColor = true;
			btnOpenFile.Click += btnOpenFile_Click;
			// 
			// btnSaveFile
			// 
			btnSaveFile.Location = new Point(12, 66);
			btnSaveFile.Name = "btnSaveFile";
			btnSaveFile.Size = new Size(113, 48);
			btnSaveFile.TabIndex = 1;
			btnSaveFile.Text = "Сохранить";
			btnSaveFile.UseVisualStyleBackColor = true;
			btnSaveFile.Click += btnSaveFile_Click;
			// 
			// textBox
			// 
			textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox.Location = new Point(131, 12);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.ScrollBars = ScrollBars.Both;
			textBox.Size = new Size(302, 250);
			textBox.TabIndex = 2;
			// 
			// btnOpenNumsInFileSummator
			// 
			btnOpenNumsInFileSummator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnOpenNumsInFileSummator.Location = new Point(12, 219);
			btnOpenNumsInFileSummator.Name = "btnOpenNumsInFileSummator";
			btnOpenNumsInFileSummator.Size = new Size(113, 43);
			btnOpenNumsInFileSummator.TabIndex = 3;
			btnOpenNumsInFileSummator.Text = "Открыть счётчик чисел";
			btnOpenNumsInFileSummator.UseVisualStyleBackColor = true;
			btnOpenNumsInFileSummator.Click += btnOpenNumsInFileSummator_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(445, 274);
			Controls.Add(btnOpenNumsInFileSummator);
			Controls.Add(textBox);
			Controls.Add(btnSaveFile);
			Controls.Add(btnOpenFile);
			Name = "MainForm";
			Padding = new Padding(10);
			Text = "Приложение";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOpenFile;
		private Button btnSaveFile;
		private TextBox textBox;
		private Button btnOpenNumsInFileSummator;
	}
}
