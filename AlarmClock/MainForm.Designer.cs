namespace AlarmClock
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
			machineTimeLabel = new Label();
			targetTimeInput = new MaskedTextBox();
			btnToggleAlarm = new Button();
			SuspendLayout();
			// 
			// machineTimeLabel
			// 
			machineTimeLabel.Dock = DockStyle.Top;
			machineTimeLabel.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			machineTimeLabel.Location = new Point(0, 0);
			machineTimeLabel.Name = "machineTimeLabel";
			machineTimeLabel.Size = new Size(318, 69);
			machineTimeLabel.TabIndex = 0;
			machineTimeLabel.Text = "12:00:00:000";
			machineTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// targetTimeInput
			// 
			targetTimeInput.Anchor = AnchorStyles.Top;
			targetTimeInput.Font = new Font("Segoe UI", 16F);
			targetTimeInput.Location = new Point(78, 72);
			targetTimeInput.Mask = "00:00";
			targetTimeInput.Name = "targetTimeInput";
			targetTimeInput.Size = new Size(163, 36);
			targetTimeInput.TabIndex = 1;
			targetTimeInput.TextAlign = HorizontalAlignment.Center;
			targetTimeInput.ValidatingType = typeof(DateTime);
			// 
			// btnToggleAlarm
			// 
			btnToggleAlarm.Anchor = AnchorStyles.Top;
			btnToggleAlarm.AutoSize = true;
			btnToggleAlarm.Location = new Point(118, 122);
			btnToggleAlarm.Name = "btnToggle";
			btnToggleAlarm.Size = new Size(83, 30);
			btnToggleAlarm.TabIndex = 2;
			btnToggleAlarm.Text = "Завести";
			btnToggleAlarm.UseVisualStyleBackColor = true;
			btnToggleAlarm.Click += btnToggle_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(318, 163);
			Controls.Add(btnToggleAlarm);
			Controls.Add(targetTimeInput);
			Controls.Add(machineTimeLabel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "MainForm";
			Text = "Alarm clock";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label machineTimeLabel;
		private MaskedTextBox targetTimeInput;
		private Button btnToggleAlarm;
	}
}
