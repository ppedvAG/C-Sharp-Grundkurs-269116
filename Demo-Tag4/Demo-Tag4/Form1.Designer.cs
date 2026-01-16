namespace Demo_Tag4
{
    partial class frmCalculator
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
			txtTermInput = new TextBox();
			btnCalculate = new Button();
			lblInfo = new Label();
			lblErgebnis = new Label();
			btnClear = new Button();
			SuspendLayout();
			// 
			// txtTermInput
			// 
			txtTermInput.Location = new Point(95, 75);
			txtTermInput.Name = "txtTermInput";
			txtTermInput.Size = new Size(200, 39);
			txtTermInput.TabIndex = 0;
			// 
			// btnCalculate
			// 
			btnCalculate.Location = new Point(421, 68);
			btnCalculate.Name = "btnCalculate";
			btnCalculate.Size = new Size(150, 46);
			btnCalculate.TabIndex = 1;
			btnCalculate.Text = "calculate";
			btnCalculate.UseVisualStyleBackColor = true;
			btnCalculate.Click += btnCalculate_Click;
			// 
			// lblInfo
			// 
			lblInfo.AutoSize = true;
			lblInfo.Location = new Point(103, 22);
			lblInfo.Name = "lblInfo";
			lblInfo.Size = new Size(127, 32);
			lblInfo.TabIndex = 2;
			lblInfo.Text = "input term";
			// 
			// lblErgebnis
			// 
			lblErgebnis.AutoSize = true;
			lblErgebnis.Location = new Point(433, 138);
			lblErgebnis.Name = "lblErgebnis";
			lblErgebnis.Size = new Size(29, 32);
			lblErgebnis.TabIndex = 3;
			lblErgebnis.Text = "...";
			// 
			// btnClear
			// 
			btnClear.Location = new Point(429, 200);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(150, 46);
			btnClear.TabIndex = 4;
			btnClear.Text = "clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			btnClear.MouseLeave += btnClear_MouseLeave;
			btnClear.MouseHover += btnClear_MouseHover;
			// 
			// frmCalculator
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(726, 266);
			Controls.Add(btnClear);
			Controls.Add(lblErgebnis);
			Controls.Add(lblInfo);
			Controls.Add(btnCalculate);
			Controls.Add(txtTermInput);
			Name = "frmCalculator";
			Text = "Calculator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtTermInput;
		private Button btnCalculate;
		private Label lblInfo;
		private Label lblErgebnis;
		private Button btnClear;
	}
}
