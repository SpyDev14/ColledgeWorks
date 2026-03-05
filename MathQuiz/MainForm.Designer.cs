namespace MathQuiz
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
			components = new System.ComponentModel.Container();
			Label label1234;
			Label label1;
			Label label2;
			Label label3;
			Label label4;
			Label label5;
			Label label6;
			Label label7;
			Label label8;
			lblTime = new Label();
			lblSumLOp = new Label();
			lblSumROp = new Label();
			numInputSum = new NumericUpDown();
			btnStart = new Button();
			numInputSub = new NumericUpDown();
			numInputMul = new NumericUpDown();
			numInputDiv = new NumericUpDown();
			lblSubROp = new Label();
			lblMulROp = new Label();
			lblDivROp = new Label();
			lblSubLOp = new Label();
			lblMulLOp = new Label();
			lblDivLOp = new Label();
			timer = new System.Windows.Forms.Timer(components);
			label1234 = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)numInputSum).BeginInit();
			((System.ComponentModel.ISupportInitialize)numInputSub).BeginInit();
			((System.ComponentModel.ISupportInitialize)numInputMul).BeginInit();
			((System.ComponentModel.ISupportInitialize)numInputDiv).BeginInit();
			SuspendLayout();
			// 
			// label1234
			// 
			label1234.AutoSize = true;
			label1234.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1234.Location = new Point(12, 9);
			label1234.Name = "label1234";
			label1234.Size = new Size(151, 30);
			label1234.TabIndex = 0;
			label1234.Text = "ВАШЕ ВРЕМЯ:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label1.Location = new Point(53, 63);
			label1.Name = "label1";
			label1.Size = new Size(28, 30);
			label1.TabIndex = 4;
			label1.Text = "+";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label2.Location = new Point(115, 63);
			label2.Name = "label2";
			label2.Size = new Size(28, 30);
			label2.TabIndex = 5;
			label2.Text = "=";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label3.Location = new Point(55, 99);
			label3.Name = "label3";
			label3.Size = new Size(21, 30);
			label3.TabIndex = 8;
			label3.Text = "-";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label4.Location = new Point(53, 134);
			label4.Name = "label4";
			label4.Size = new Size(23, 30);
			label4.TabIndex = 9;
			label4.Text = "*";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label5.Location = new Point(53, 164);
			label5.Name = "label5";
			label5.Size = new Size(22, 30);
			label5.TabIndex = 10;
			label5.Text = "/";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label6.Location = new Point(115, 99);
			label6.Name = "label6";
			label6.Size = new Size(28, 30);
			label6.TabIndex = 11;
			label6.Text = "=";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label7.Location = new Point(115, 134);
			label7.Name = "label7";
			label7.Size = new Size(28, 30);
			label7.TabIndex = 12;
			label7.Text = "=";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			label8.Location = new Point(115, 164);
			label8.Name = "label8";
			label8.Size = new Size(28, 30);
			label8.TabIndex = 13;
			label8.Text = "=";
			// 
			// lblTime
			// 
			lblTime.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			lblTime.Location = new Point(158, 9);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(103, 30);
			lblTime.TabIndex = 23;
			lblTime.Text = "30";
			lblTime.TextAlign = ContentAlignment.TopRight;
			// 
			// lblSumLOp
			// 
			lblSumLOp.AutoSize = true;
			lblSumLOp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblSumLOp.Location = new Point(25, 63);
			lblSumLOp.Name = "lblSumLOp";
			lblSumLOp.Size = new Size(22, 30);
			lblSumLOp.TabIndex = 2;
			lblSumLOp.Text = "?";
			// 
			// lblSumROp
			// 
			lblSumROp.AutoSize = true;
			lblSumROp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblSumROp.Location = new Point(87, 63);
			lblSumROp.Name = "lblSumROp";
			lblSumROp.Size = new Size(22, 30);
			lblSumROp.TabIndex = 3;
			lblSumROp.Text = "?";
			// 
			// numInputSum
			// 
			numInputSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			numInputSum.Location = new Point(149, 64);
			numInputSum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numInputSum.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
			numInputSum.Name = "numInputSumm";
			numInputSum.Size = new Size(112, 29);
			numInputSum.TabIndex = 6;
			numInputSum.TextAlign = HorizontalAlignment.Center;
			// 
			// btnStart
			// 
			btnStart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnStart.Location = new Point(12, 211);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(249, 38);
			btnStart.TabIndex = 7;
			btnStart.Text = "НАЧАТЬ ВАШ ПРОВЕРКА!!!";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += btnStart_Click;
			// 
			// numInputSub
			// 
			numInputSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			numInputSub.Location = new Point(149, 99);
			numInputSub.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numInputSub.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
			numInputSub.Name = "numInputSub";
			numInputSub.Size = new Size(112, 29);
			numInputSub.TabIndex = 14;
			numInputSub.TextAlign = HorizontalAlignment.Center;
			// 
			// numInputMul
			// 
			numInputMul.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			numInputMul.Location = new Point(149, 134);
			numInputMul.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numInputMul.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
			numInputMul.Name = "numInputMul";
			numInputMul.Size = new Size(112, 29);
			numInputMul.TabIndex = 15;
			numInputMul.TextAlign = HorizontalAlignment.Center;
			// 
			// numInputDiv
			// 
			numInputDiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			numInputDiv.Location = new Point(149, 169);
			numInputDiv.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numInputDiv.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
			numInputDiv.Name = "numInputDiv";
			numInputDiv.Size = new Size(112, 29);
			numInputDiv.TabIndex = 16;
			numInputDiv.TextAlign = HorizontalAlignment.Center;
			// 
			// lblSubROp
			// 
			lblSubROp.AutoSize = true;
			lblSubROp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblSubROp.Location = new Point(87, 99);
			lblSubROp.Name = "lblSubROp";
			lblSubROp.Size = new Size(22, 30);
			lblSubROp.TabIndex = 17;
			lblSubROp.Text = "?";
			// 
			// lblMulROp
			// 
			lblMulROp.AutoSize = true;
			lblMulROp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblMulROp.Location = new Point(87, 134);
			lblMulROp.Name = "lblMulROp";
			lblMulROp.Size = new Size(22, 30);
			lblMulROp.TabIndex = 18;
			lblMulROp.Text = "?";
			// 
			// lblDivROp
			// 
			lblDivROp.AutoSize = true;
			lblDivROp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblDivROp.Location = new Point(87, 164);
			lblDivROp.Name = "lblDivROp";
			lblDivROp.Size = new Size(22, 30);
			lblDivROp.TabIndex = 19;
			lblDivROp.Text = "?";
			// 
			// lblSubLOp
			// 
			lblSubLOp.AutoSize = true;
			lblSubLOp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblSubLOp.Location = new Point(25, 99);
			lblSubLOp.Name = "lblSubLOp";
			lblSubLOp.Size = new Size(22, 30);
			lblSubLOp.TabIndex = 20;
			lblSubLOp.Text = "?";
			// 
			// lblMulLOp
			// 
			lblMulLOp.AutoSize = true;
			lblMulLOp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblMulLOp.Location = new Point(25, 134);
			lblMulLOp.Name = "lblMulLOp";
			lblMulLOp.Size = new Size(22, 30);
			lblMulLOp.TabIndex = 21;
			lblMulLOp.Text = "?";
			// 
			// lblDivLOp
			// 
			lblDivLOp.AutoSize = true;
			lblDivLOp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
			lblDivLOp.Location = new Point(25, 164);
			lblDivLOp.Name = "lblDivLOp";
			lblDivLOp.Size = new Size(22, 30);
			lblDivLOp.TabIndex = 22;
			lblDivLOp.Text = "?";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(273, 261);
			Controls.Add(lblTime);
			Controls.Add(lblDivLOp);
			Controls.Add(lblMulLOp);
			Controls.Add(lblSubLOp);
			Controls.Add(lblDivROp);
			Controls.Add(lblMulROp);
			Controls.Add(lblSubROp);
			Controls.Add(numInputDiv);
			Controls.Add(numInputMul);
			Controls.Add(numInputSub);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(btnStart);
			Controls.Add(numInputSum);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lblSumROp);
			Controls.Add(lblSumLOp);
			Controls.Add(label1234);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "ТЕСТ НА ВАШ ИНТЕЛЕКТ";
			((System.ComponentModel.ISupportInitialize)numInputSum).EndInit();
			((System.ComponentModel.ISupportInitialize)numInputSub).EndInit();
			((System.ComponentModel.ISupportInitialize)numInputMul).EndInit();
			((System.ComponentModel.ISupportInitialize)numInputDiv).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblSumLOp;
		private Label lblSumROp;
		private NumericUpDown numInputSum;
		private Button btnStart;
		private NumericUpDown numInputSub;
		private NumericUpDown numInputMul;
		private NumericUpDown numInputDiv;
		private Label lblSubROp;
		private Label lblMulROp;
		private Label lblDivROp;
		private Label lblSubLOp;
		private Label lblMulLOp;
		private Label lblDivLOp;
		private System.Windows.Forms.Timer timer;
		private Label lblTime;
	}
}
