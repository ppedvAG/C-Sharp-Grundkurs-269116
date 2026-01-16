namespace Demo_Tag4
{
	public partial class frmCalculator : Form
	{

		bool status;

		public frmCalculator()
		{
			InitializeComponent();
			status = false;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				Term term = new Term(txtTermInput.Text);
				lblErgebnis.Text = "" + Term.BerechneTerm(term);
			}
			//Catch-Blöcke zur Bearbeitung der Fehler
			catch (OverflowException)
			{
				MessageBox.Show("Eine deiner Zahlen war zu groß oder zu klein.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			catch (FormatException)
			{
				MessageBox.Show("Du hast ein nicht-erlaubtes Zeichen verwendet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (DivideByZeroException)
			{
				MessageBox.Show("Du hast versucht durch 0 zu teilen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Du hast ein nicht-erlaubtes Rechenzeichen verwendet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception)
			{

			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Möchtest du wirklich die Eingaben löschen?", "Eingaben löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				txtTermInput.Text = "";
				lblErgebnis.Text = "";
				status = true;
			}
		}

		private void btnClear_MouseHover(object sender, EventArgs e)
		{
			btnClear.BackColor = Color.Red;
		}

		private void btnClear_MouseLeave(object sender, EventArgs e)
		{
			btnClear.BackColor=SystemColors.Window;
		}
	}
}
