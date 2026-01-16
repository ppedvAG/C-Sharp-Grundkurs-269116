namespace Lab_Modul14
{
	partial class Form1
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
			lblListLabel = new Label();
			lstFahrzeuge = new ListBox();
			btnNeuesFahrzeug = new Button();
			btnLoescheFahrzeug = new Button();
			lblFahrzeuginfo = new Label();
			btnLadeFahrzeuge = new Button();
			btnSpeichereFahrzeuge = new Button();
			SuspendLayout();
			// 
			// lblListLabel
			// 
			lblListLabel.AutoSize = true;
			lblListLabel.Location = new Point(41, 34);
			lblListLabel.Name = "lblListLabel";
			lblListLabel.Size = new Size(260, 32);
			lblListLabel.TabIndex = 0;
			lblListLabel.Text = "Vorhandene Farhzeuge";
			// 
			// lstFahrzeuge
			// 
			lstFahrzeuge.FormattingEnabled = true;
			lstFahrzeuge.Location = new Point(41, 69);
			lstFahrzeuge.Name = "lstFahrzeuge";
			lstFahrzeuge.Size = new Size(694, 292);
			lstFahrzeuge.TabIndex = 1;
			lstFahrzeuge.SelectedIndexChanged += lstFahrzeuge_SelectedIndexChanged;
			// 
			// btnNeuesFahrzeug
			// 
			btnNeuesFahrzeug.Location = new Point(772, 69);
			btnNeuesFahrzeug.Name = "btnNeuesFahrzeug";
			btnNeuesFahrzeug.Size = new Size(150, 95);
			btnNeuesFahrzeug.TabIndex = 2;
			btnNeuesFahrzeug.Text = "Neues Fahrzeug";
			btnNeuesFahrzeug.UseVisualStyleBackColor = true;
			btnNeuesFahrzeug.Click += btnNeuesFahrzeug_Click;
			// 
			// btnLoescheFahrzeug
			// 
			btnLoescheFahrzeug.Location = new Point(772, 170);
			btnLoescheFahrzeug.Name = "btnLoescheFahrzeug";
			btnLoescheFahrzeug.Size = new Size(150, 106);
			btnLoescheFahrzeug.TabIndex = 3;
			btnLoescheFahrzeug.Text = "Lösche Fahrzeug";
			btnLoescheFahrzeug.UseVisualStyleBackColor = true;
			btnLoescheFahrzeug.Click += btnLoescheFahrzeug_Click;
			// 
			// lblFahrzeuginfo
			// 
			lblFahrzeuginfo.Location = new Point(41, 386);
			lblFahrzeuginfo.Name = "lblFahrzeuginfo";
			lblFahrzeuginfo.Size = new Size(694, 107);
			lblFahrzeuginfo.TabIndex = 4;
			lblFahrzeuginfo.Text = "Fahrzeuginfo";
			// 
			// btnLadeFahrzeuge
			// 
			btnLadeFahrzeuge.Location = new Point(772, 282);
			btnLadeFahrzeuge.Name = "btnLadeFahrzeuge";
			btnLadeFahrzeuge.Size = new Size(150, 106);
			btnLadeFahrzeuge.TabIndex = 5;
			btnLadeFahrzeuge.Text = "Lade Fahrzeuge";
			btnLadeFahrzeuge.UseVisualStyleBackColor = true;
			btnLadeFahrzeuge.Click += btnLadeFahrzeuge_Click;
			// 
			// btnSpeichereFahrzeuge
			// 
			btnSpeichereFahrzeuge.Location = new Point(772, 394);
			btnSpeichereFahrzeuge.Name = "btnSpeichereFahrzeuge";
			btnSpeichereFahrzeuge.Size = new Size(150, 106);
			btnSpeichereFahrzeuge.TabIndex = 6;
			btnSpeichereFahrzeuge.Text = "Speichere Fahrzeuge";
			btnSpeichereFahrzeuge.UseVisualStyleBackColor = true;
			btnSpeichereFahrzeuge.Click += btnSpeichereFahrzeuge_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(968, 536);
			Controls.Add(btnSpeichereFahrzeuge);
			Controls.Add(btnLadeFahrzeuge);
			Controls.Add(lblFahrzeuginfo);
			Controls.Add(btnLoescheFahrzeug);
			Controls.Add(btnNeuesFahrzeug);
			Controls.Add(lstFahrzeuge);
			Controls.Add(lblListLabel);
			Name = "Form1";
			Text = "Form1";
			FormClosing += Form1_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblListLabel;
		private ListBox lstFahrzeuge;
		private Button btnNeuesFahrzeug;
		private Button btnLoescheFahrzeug;
		private Label lblFahrzeuginfo;
		private Button btnLadeFahrzeuge;
		private Button btnSpeichereFahrzeuge;
	}
}
