namespace Fahrzeugpark
{
	class Program
	{
		static void Main(string[] args)
		{
			//Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
			Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
			Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
			Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
			Random random = new Random();
			//Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
			int anzahlFahrzeuge = 10;

			//Schleife zur zufälligen Befüllung von Queue und Stack
			for (int i = 0; i < anzahlFahrzeuge; i++)
			{
				Fahrzeug generiertesQF = Fahrzeug.GeneriereFahrzeug($"Q{i}");
				Fahrzeug generiertesSF = Fahrzeug.GeneriereFahrzeug($"S{i}");

				Console.WriteLine(generiertesSF.ToString());
				Console.WriteLine(generiertesQF.ToString());

				fzQueue.Enqueue(generiertesQF);
				fzStack.Push(generiertesSF);
			}


			for (int i = 0; i < anzahlFahrzeuge; i++)
			{
				// Methode ohne verwendung der Methode BeladeWennBeladbar (es wird nur auf fzQueue geladen)
				////Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
				//if (fzQueue.Peek() is IBeladbar)
				//{
				//	//...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
				//	((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
				//	//...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
				//	fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
				//}
				//else
				//{
				//	//... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
				//	fzQueue.Dequeue();
				//	fzStack.Pop();
				//}

				// Methode mit Verwendung der Methode BeladeWennBeladbar (für beide Collections)
				IBeladbar beladenesObjekt = BeladeWennBeladbar(fzQueue.Peek(), fzStack.Peek());
				if(beladenesObjekt != null)
				{
					fzDict.Add(beladenesObjekt as Fahrzeug, beladenesObjekt.GeladenesFahrzeug);
					fzQueue.Dequeue();
					fzStack.Pop();
				}
				else
				{
					fzQueue.Dequeue();
					fzStack.Pop();
				}
			}


			Console.WriteLine("\n----------LADELISTE----------");

			//Schleife zur Ausgabe des Dictionaries
			foreach (var item in fzDict)
			{
				Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
			}

		}

		static IBeladbar BeladeWennBeladbar(Object o1, Object o2)
		{
			if(o1 is IBeladbar && o2 is Fahrzeug)
			{
				((IBeladbar)o1).Belade(o2 as Fahrzeug);
				return o1 as IBeladbar;
			} 
			if(o2 is IBeladbar && o1 is Fahrzeug)
			{
				(o2 as IBeladbar).Belade((Fahrzeug)o1);
				return (IBeladbar)o2;
			}
			return null;
		}
	}
}