public class Demo
{
	public static void Main() 	
	{
		/// Das ist ein Kommentar
		/// sdf
		/// sdf
		/// sdf


		// boolean können nur mit true oder false zugewiesen werden
		bool boolean = true;
		//boolean = 1;

		// Konvertierungen
		// Zahl zu text
		int zahl = 42;	
		string text1 = zahl.ToString(); // Explizit
		string text2 = $"{zahl}";       // Implizit
		string text3 = "" + zahl;       // Implizit

		//Text zu Zahl
		zahl = int.Parse(text1); // ohne Fehlerbehandlung
		bool funktioniert = int.TryParse(text1, out zahl); // mit Fehlerbehandlung
		Console.WriteLine($"Funktioniert: {funktioniert}, Zahl: {zahl}");
		funktioniert = int.TryParse("Hallo", out zahl); // mit Fehlerbehandlung
		Console.WriteLine($"Funktioniert: {funktioniert}, Zahl: {zahl}");

		// double zu int

		double kommazahl = 3.94;
		int zahl2 = (int) kommazahl;
		// Zahl wird abgeschnitten nicht gerundet
		Console.WriteLine($"Kommazahl: {kommazahl}, Zahl2: {zahl2}");

		Console.WriteLine($"3 / 7 = {(double)zahl2 / 7}");




		// Arrays
		int[] zahlen = new int[] {1,3,5,7,9};


		// boolsche Operatoren

		if (1 <= 1 ) ; // kleiner gleich
		if (1 >= 1) ; // größer gleich		
		if(1 == 1) ; // gleich
		if (1 != 1) ;


		// Überladene Funktion Beispiel Round

		Console.WriteLine(Math.Round(3.14159));
		Console.WriteLine(Math.Round(3.14159, 2));


		// Readkey wartet auf eine Eingabe des Benutzers
		Console.ReadKey();
	}
}


