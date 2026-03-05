namespace PickUpPair
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
			board = new TableLayoutPanel();
			label16 = new Label();
			label15 = new Label();
			label14 = new Label();
			label13 = new Label();
			label12 = new Label();
			label11 = new Label();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			timer = new System.Windows.Forms.Timer(components);
			board.SuspendLayout();
			SuspendLayout();
			// 
			// board
			// 
			board.BackColor = Color.CornflowerBlue;
			board.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			board.ColumnCount = 4;
			board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			board.Controls.Add(label16, 3, 3);
			board.Controls.Add(label15, 2, 3);
			board.Controls.Add(label14, 1, 3);
			board.Controls.Add(label13, 0, 3);
			board.Controls.Add(label12, 3, 2);
			board.Controls.Add(label11, 2, 2);
			board.Controls.Add(label10, 1, 2);
			board.Controls.Add(label9, 0, 2);
			board.Controls.Add(label8, 3, 1);
			board.Controls.Add(label7, 2, 1);
			board.Controls.Add(label6, 1, 1);
			board.Controls.Add(label5, 0, 1);
			board.Controls.Add(label4, 3, 0);
			board.Controls.Add(label3, 2, 0);
			board.Controls.Add(label2, 1, 0);
			board.Controls.Add(label1, 0, 0);
			board.Dock = DockStyle.Fill;
			board.Location = new Point(10, 10);
			board.Name = "board";
			board.RowCount = 4;
			board.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			board.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			board.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			board.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			board.Size = new Size(499, 441);
			board.TabIndex = 0;
			// 
			// label16
			// 
			label16.Dock = DockStyle.Fill;
			label16.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label16.ForeColor = SystemColors.ControlText;
			label16.Location = new Point(377, 329);
			label16.Name = "label16";
			label16.Size = new Size(117, 110);
			label16.TabIndex = 15;
			label16.Text = "Q";
			label16.TextAlign = ContentAlignment.MiddleCenter;
			label16.Click += AnyLabel_Click;
			// 
			// label15
			// 
			label15.Dock = DockStyle.Fill;
			label15.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label15.ForeColor = SystemColors.ControlText;
			label15.Location = new Point(253, 329);
			label15.Name = "label15";
			label15.Size = new Size(116, 110);
			label15.TabIndex = 14;
			label15.Text = "Q";
			label15.TextAlign = ContentAlignment.MiddleCenter;
			label15.Click += AnyLabel_Click;
			// 
			// label14
			// 
			label14.Dock = DockStyle.Fill;
			label14.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label14.ForeColor = SystemColors.ControlText;
			label14.Location = new Point(129, 329);
			label14.Name = "label14";
			label14.Size = new Size(116, 110);
			label14.TabIndex = 13;
			label14.Text = "Q";
			label14.TextAlign = ContentAlignment.MiddleCenter;
			label14.Click += AnyLabel_Click;
			// 
			// label13
			// 
			label13.Dock = DockStyle.Fill;
			label13.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label13.ForeColor = SystemColors.ControlText;
			label13.Location = new Point(5, 329);
			label13.Name = "label13";
			label13.Size = new Size(116, 110);
			label13.TabIndex = 12;
			label13.Text = "Q";
			label13.TextAlign = ContentAlignment.MiddleCenter;
			label13.Click += AnyLabel_Click;
			// 
			// label12
			// 
			label12.Dock = DockStyle.Fill;
			label12.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label12.ForeColor = SystemColors.ControlText;
			label12.Location = new Point(377, 220);
			label12.Name = "label12";
			label12.Size = new Size(117, 107);
			label12.TabIndex = 11;
			label12.Text = "Q";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			label12.Click += AnyLabel_Click;
			// 
			// label11
			// 
			label11.Dock = DockStyle.Fill;
			label11.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label11.ForeColor = SystemColors.ControlText;
			label11.Location = new Point(253, 220);
			label11.Name = "label11";
			label11.Size = new Size(116, 107);
			label11.TabIndex = 10;
			label11.Text = "Q";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			label11.Click += AnyLabel_Click;
			// 
			// label10
			// 
			label10.Dock = DockStyle.Fill;
			label10.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label10.ForeColor = SystemColors.ControlText;
			label10.Location = new Point(129, 220);
			label10.Name = "label10";
			label10.Size = new Size(116, 107);
			label10.TabIndex = 9;
			label10.Text = "Q";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			label10.Click += AnyLabel_Click;
			// 
			// label9
			// 
			label9.Dock = DockStyle.Fill;
			label9.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label9.ForeColor = SystemColors.ControlText;
			label9.Location = new Point(5, 220);
			label9.Name = "label9";
			label9.Size = new Size(116, 107);
			label9.TabIndex = 8;
			label9.Text = "Q";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			label9.Click += AnyLabel_Click;
			// 
			// label8
			// 
			label8.Dock = DockStyle.Fill;
			label8.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label8.ForeColor = SystemColors.ControlText;
			label8.Location = new Point(377, 111);
			label8.Name = "label8";
			label8.Size = new Size(117, 107);
			label8.TabIndex = 7;
			label8.Text = "Q";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			label8.Click += AnyLabel_Click;
			// 
			// label7
			// 
			label7.Dock = DockStyle.Fill;
			label7.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label7.ForeColor = SystemColors.ControlText;
			label7.Location = new Point(253, 111);
			label7.Name = "label7";
			label7.Size = new Size(116, 107);
			label7.TabIndex = 6;
			label7.Text = "Q";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			label7.Click += AnyLabel_Click;
			// 
			// label6
			// 
			label6.Dock = DockStyle.Fill;
			label6.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label6.ForeColor = SystemColors.ControlText;
			label6.Location = new Point(129, 111);
			label6.Name = "label6";
			label6.Size = new Size(116, 107);
			label6.TabIndex = 5;
			label6.Text = "Q";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			label6.Click += AnyLabel_Click;
			// 
			// label5
			// 
			label5.Dock = DockStyle.Fill;
			label5.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label5.ForeColor = SystemColors.ControlText;
			label5.Location = new Point(5, 111);
			label5.Name = "label5";
			label5.Size = new Size(116, 107);
			label5.TabIndex = 4;
			label5.Text = "Q";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			label5.Click += AnyLabel_Click;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Fill;
			label4.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label4.ForeColor = SystemColors.ControlText;
			label4.Location = new Point(377, 2);
			label4.Name = "label4";
			label4.Size = new Size(117, 107);
			label4.TabIndex = 3;
			label4.Text = "Q";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			label4.Click += AnyLabel_Click;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Fill;
			label3.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label3.ForeColor = SystemColors.ControlText;
			label3.Location = new Point(253, 2);
			label3.Name = "label3";
			label3.Size = new Size(116, 107);
			label3.TabIndex = 2;
			label3.Text = "Q";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.Click += AnyLabel_Click;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Fill;
			label2.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label2.ForeColor = SystemColors.ControlText;
			label2.Location = new Point(129, 2);
			label2.Name = "label2";
			label2.Size = new Size(116, 107);
			label2.TabIndex = 1;
			label2.Text = "Q";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.Click += AnyLabel_Click;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Wingdings", 48F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label1.ForeColor = SystemColors.ControlText;
			label1.Location = new Point(5, 2);
			label1.Name = "label1";
			label1.Size = new Size(116, 107);
			label1.TabIndex = 0;
			label1.Text = "Q";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += AnyLabel_Click;
			// 
			// timer
			// 
			timer.Tick += timer_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(519, 461);
			Controls.Add(board);
			Name = "MainForm";
			Padding = new Padding(10);
			Text = "Pick a Pair";
			ResizeBegin += MainForm_ResizeBegin;
			ResizeEnd += MainForm_ResizeEnd;
			board.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel board;
		private Label label1;
		private Label label16;
		private Label label15;
		private Label label14;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private System.Windows.Forms.Timer timer;
	}
}
