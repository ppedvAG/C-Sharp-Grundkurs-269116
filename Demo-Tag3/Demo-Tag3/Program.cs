namespace Demo_Tag3
{
	class Program
	{
		static void Main(string[] args)
		{
			//// Fehlerbehandlung
			//Console.WriteLine("Zahl eingeben");

			//try
			//{
			//	int number = int.Parse(Console.ReadLine());
			//}
			//catch (FormatException e)
			//{
			//	Console.WriteLine("Falsches Format, bitte eine Ganze Zahl eingeben");
			//}
			//catch (OverflowException e)
			//{
			//	Console.WriteLine("Zahl zu groß");
			//}
			//catch (ArgumentNullException e) // Wird nie Erreicht weil ReadLine nie Null liefert
			//{
			//	Console.WriteLine("Parameter von Parse darf nicht Null sein");
			//} finally
			//{
			//	Console.WriteLine("Wird immer angezeigt");
			//}

			//// NumberInput mit try catch
			//try
			//{
			//	double number = CalculatorMethods.NumberInput("Eine Zahl eingeben:");
			//}
			//catch (IncorrectInputException e)
			//{
			//	Console.WriteLine(e.Message);
			//}


			//// Calculate mit Division durch 0 soll Exception werfen
			//try
			//{
			//	double result = CalculatorMethods.Calculate(12, 0, CalculatorMethods.MathematicOperation.Division);
			//} catch(DivideByZeroException e)
			//{
			//	Console.WriteLine(e.Message);
			//}

			// Listen in C#
			//List<int> numbers = new List<int>();
			//numbers.Add(15);
			//numbers.Add(20);
			//numbers.Add(30);
			//numbers.Add(5);
			//numbers.Add(10);


			//// Iteration über Liste mit for-Schleife
			//foreach(int number in numbers)
			//{
			//	Console.Write(number+", ");
			//}
			//Console.WriteLine();

			//// Listen haben viele nützliche Methoden
			//numbers.Remove(15); // Entfernt 15 aus der Liste
			//numbers.Sort(); // Sortiert die Liste aufsteigend
			//Console.WriteLine("15 entfernt und Liste sortiert:");
			//foreach (int number in numbers)
			//{
			//	Console.Write(number + ", ");
			//}
			//Console.WriteLine();

			//numbers.RemoveAt(numbers.Count - 1); // Entfernt das letzte Element der Liste
			//Console.WriteLine("Letztes Element entfernt:");
			//foreach (int number in numbers)
			//{
			//	Console.Write(number + ", ");
			//}
			//Console.WriteLine();

			//numbers.AddRange(numbers); // AddRange kann eine Liste an eine Liste anhängen, in diesem Fall verdoppeln wir die Number Liste
			//Console.WriteLine("Liste Verdoppelt");
			//foreach (int number in numbers)
			//{
			//	Console.Write(number + ", ");
			//}
			//Console.WriteLine();

			////numbers.Clear(); // Entfernt alle Elemente aus der Liste

			//Console.WriteLine("AVG: "+ numbers.Average()); // Berechnet den Durchschnitt der Zahlen in der Liste


			//// Dictionary

			//Dictionary<string, int> AgeOfPersons = new Dictionary<string, int>();
			//AgeOfPersons.Add("Max", 25);
			//AgeOfPersons.Add("Anna", 30);
			//AgeOfPersons.Add("John", 22);
			////AgeOfPersons.Add("Max", 28); // Führt zu Fehler, da Key "Max" schon existiert

			//Console.WriteLine("Alter von Anna: " + AgeOfPersons["Anna"]); // Zugriff auf Wert über Key


			//// Generische Liste von Klasse genericList verwenden
			//genericList<string> stringList = new genericList<string>();
			//stringList.AddItem("Hallo");
			//genericList<int> intList = new genericList<int>();

			//genericList<double> doubleList = new genericList<double>();

			// Erweiterungsmethoden
			List<int> zahlen = new List<int>();
			//zahlen.Max(); // .Max ist eine Erweiterungsmethode für Listen aus dem Namespace System.Linq

			// eigene Erweitngsmethode verwenden
			Console.WriteLine("TextTest".CountCapitalCharecters()); // Eigene Erweiterungsmethode aus Erweiterungsmethoden.cs


		}
	}

	// Generische Liste in Klasse
	class genericList<T>
	{
		private List<T> items = new List<T>();

		public T Value1 { get; set; }
		public T Value2 { get; set; }


		public void AddItem(T item)
		{
			items.Add(item);
		}
		public void RemoveItem(T item)
		{
			items.Remove(item);
		}
		public void PrintItems()
		{
			foreach (T item in items)
			{
				Console.Write(item + ", ");
			}
			Console.WriteLine();
		}
	}
}