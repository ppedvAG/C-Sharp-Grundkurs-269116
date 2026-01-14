namespace Fahrzeugpark
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			#region Lab 06-07
			//Lab08 ist Erweiterung von Lab07
			#endregion

			#region Lab 08: Vererbung

			//Instanziierung verschiedener Fahrzeuge
			PKW pkw1 = new PKW("Mercedes", 210, 23000, 5);
			Schiff schiff1 = new Schiff("Titanic", 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
			Flugzeug flugzeug1 = new Flugzeug("Boing", 350, 90000000, 9800);

			//Ausgabe der verschiedenen Info()-Methoden
			Console.WriteLine(pkw1.Info());
			Console.WriteLine(schiff1.Info());
			Console.WriteLine(flugzeug1.Info());


			Fahrzeug fz;


			fz = new PKW("Audi", 240, 27000, 3);


			#endregion

		}
	}
}