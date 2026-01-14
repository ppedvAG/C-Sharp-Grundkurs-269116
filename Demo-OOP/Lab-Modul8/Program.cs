namespace Fahrzeugpark
{
	class Program
	{
		static void Main(string[] args)
		{
			// neues Array mit 10 Fahrzeugen
			Fahrzeug[] fahrzeugpark = new Fahrzeug[10];
			for (int i = 0; i < 10; i++)
			{
				// Fahrzeug generieren und im Array speichern
				fahrzeugpark[i] = Fahrzeug.GeneriereFahrzeug("Fahrzeug" + (i+1));
			}

			// Zähler für die Fahrzeugtypen
			int anzPKW = 0, anzSchiff = 0, anzFlugzeug = 0;

			foreach(Fahrzeug fz in fahrzeugpark)
			{
				// ToString-Methode aufrufen und Fahrzeugtyp zählen
				Console.WriteLine(fz.ToString());
				if(fz is PKW)
					anzPKW++;
				else if(fz is Schiff)
					anzSchiff++;
				else if(fz is Flugzeug)
					anzFlugzeug++;
			}

			// Ausgabe der Zählerstände
			Console.WriteLine($"\nIm Fahrzeugpark befinden sich:\n" +
				$"{anzPKW} PKWs\n{anzSchiff} Schiffe\n{anzFlugzeug} Flugzeuge");

			fahrzeugpark[2].Hupen();

		}
	}
}