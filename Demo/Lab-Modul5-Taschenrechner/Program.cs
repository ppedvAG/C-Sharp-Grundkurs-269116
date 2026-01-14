using System;
using System.Linq;
using System.Text.RegularExpressions;

using Lab_Modul5_Taschenrechner;

class Program
{
	//Enum-Definition
	internal enum MathematicOperation { Addition = 1, Subtraktion, Multiplikation, Division }

	static void Main(string[] args)
	{
		//Schleife für Programm-Wiederholung
		do
		{
			//Eingabe und Parsing der ersten Zahl
			double zahl1 = CalculatorMethods.NumberInput("\nGib eine Zahl ein: ");

			//Eingabe und Parsing der zweiten Zahl
			double zahl2 = CalculatorMethods.NumberInput("Gib eine weitere Zahl ein: ");
			

			//Anzeige der möglichen MathematicOperationen
			Console.WriteLine("\nWähle eine Rechenoperation:");

			for (int i = 1; i < 5; i++)
			{
				Console.WriteLine($"{i}: {(MathematicOperation)i}");

			}
			//Abfrage der Benutzereingabe
			
			MathematicOperation op = CalculatorMethods.MathematicOperationInput("Auswahl: ");

			//Deklaration und Initialisierung der Ergebnisvariablen
			double ergebnis = CalculatorMethods.Calculate(zahl1, zahl2, op);

			//Frage nach der Wiederholung des Programms
			Console.WriteLine("Wiederholen? (Y/N) ");
			//Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
		} while (Console.ReadKey(true).Key == ConsoleKey.Y);
	}
}


