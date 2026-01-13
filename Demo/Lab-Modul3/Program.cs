public class Program
{
	public static void Main(string[] args)
	{
		//int year;

		//Console.Write("Jahr eingeben: ");
		//// Jahr wird eingelesen, bei fehlerhafter Eingabe wird das aktuelle Jahr verwendet
		//if (!int.TryParse(Console.ReadLine(), out year))
		//	year = DateTime.Now.Year;

		//// Überprüfung, ob das Jahr ein Schaltjahr ist
		//bool isLeapYear = false;

		//if(year %4 == 0)
		//{
		//	isLeapYear = true;
		//	if(year %100==0)
		//	{
		//		isLeapYear = false;
		//		if(year % 400 == 0)
		//		{
		//			isLeapYear = true;
		//		}
		//	}
		//}

		//Console.WriteLine($"Ist {year} ein Schaltjahr? {isLeapYear}");
		//Console.WriteLine($"{year} ist {(isLeapYear ? "":"k")}ein Schaltjahr.");

		// Mini-Lotto

		int[] winningNumbers = new int[5];
		Random random = new Random();
		winningNumbers[0] = random.Next(0, 101);
		winningNumbers[1] = random.Next(0, 101);
		winningNumbers[2] = random.Next(0, 101);
		winningNumbers[3] = random.Next(0, 101);
		winningNumbers[4] = random.Next(0, 101);

		Console.WriteLine("Gib einen Tipp zwischen 0 und 100 ein: ");
		int userTip;
		if (int.TryParse(Console.ReadLine(), out userTip))
		{
			if (userTip < 0 || userTip > 100)
			{
				Console.WriteLine("Ungültiger Tipp! Bitte eine Zahl zwischen 0 und 100 eingeben.");
			}
			else
			{
				if (winningNumbers.Contains(userTip))
				{
					Console.WriteLine("Herzlichen Glückwunsch! Dein Tipp war richtig!");
				}
				else
				{
					Console.WriteLine("Leider kein Treffer. Die Gewinnzahlen waren: " + string.Join(", ", winningNumbers));
				}
			}
		}
		else
		{
			Console.WriteLine("Ungültige Eingabe! Die Gewinnzahlen waren: " + string.Join(", ", winningNumbers));
		}
	}
}