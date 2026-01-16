using Fahrzeugpark;
namespace Lab_Modul14
{
	public partial class Form1 : Form
	{
		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();

		// eigene Methode um die List Items zu aktuallisieren
		private void listeAktuallisieren()
		{
			// alle Items aus der Listbox werden gelˆscht und neu 
			// bef¸llt mit den Items aus der Fahrzeugliste
			lstFahrzeuge.Items.Clear();
			foreach (Fahrzeug fz in fahrzeuge)
			{
				lstFahrzeuge.Items.Add(fz);
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		// Eventlistener Methode wird beim Klicken auf den Button "Neues Fahrzeug" aufgerufen
		private void btnNeuesFahrzeug_Click(object sender, EventArgs e)
		{
			// F¸gt ein neues Farhzeug zur Liste fahrzeuge hinzu (nutzt die statische Methode GeneriereFahrzeug)
			fahrzeuge.Add(Fahrzeug.GeneriereFahrzeug("Fahrzeug" + Fahrzeug.AnzahlFahrzeuge));
			// Aufruf der eigenen Methode listeAktuallisieren
			listeAktuallisieren();
		}
		// Eventlistener Methode wird beim Klicken auf den Button "Lˆsche Fahrzeug" aufgerufen
		private void btnLoescheFahrzeug_Click(object sender, EventArgs e)
		{
			// ‹berpr¸ft, ob ein Fahrzeug in der ListBox ausgew‰lt ist 
			if (lstFahrzeuge.SelectedItem != null)
			{
				// Where Funktion, die alle Items in die Liste fahrzeuge speichert,
				// die nicht dem Ausgew‰hltem Fahrzeug entsprechen
				fahrzeuge = fahrzeuge.Where(f => f != lstFahrzeuge.SelectedItem).ToList();
				listeAktuallisieren(); // Methode listeAktuallisieren wird wieder aufgerufen.
			}
		}

		// Eventlistener Methode wird aufgerufen, wenn sich der Index des Ausgew‰hlten Listenelementes der Listbox ‰ndert
		private void lstFahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
		{
			// ‹berpr¸ft, ob ein Fahrzeug in der ListBox ausgew‰lt ist 
			if (lstFahrzeuge.SelectedItem != null)
			{
				// schreibt den Infotext des ausgew‰hlten Farhzeugs in das Label
				lblFahrzeuginfo.Text = ((Fahrzeug)lstFahrzeuge.SelectedItem).Info();
			}

		}

		// Eventlistener Methode wird aufgerufen, wenn das Form geschlossen werden soll (User klickt auf x)
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Fragt den User in einer MessageBox, ob er das Programm wirklich schlieﬂen will
			DialogResult result = MessageBox.Show("Programm wirklich beenden?", "Schlieﬂen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			// e sind die FormClosingEventArgs, darin ist Cancel gespeichert, welches das Schlieﬂen abbricht wenn es auf true gesetzt wird
			e.Cancel = result == DialogResult.No;
		}
	}
}
