using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Lab_Modul5_Taschenrechner
{
	internal static class CalculatorMethods
	{
		internal static double Calculate(double number1, double number2, MathematicOperation mo)
		{
			//Deklaration und Initialisierung der Ergebnisvariablen
			double ergebnis = 0.0;

			//Switch zur Auswahl der MathematicOperation
			switch (mo)
			{
				//Berechnung des Ergebnisses
				case MathematicOperation.Addition:
					Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
					return number1 + number2;
				case MathematicOperation.Subtraktion:
					Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
					return number1 - number2;
				case MathematicOperation.Multiplikation:
					Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
					return number1 * number2;
				case MathematicOperation.Division:
					//Prüfung einer möglichen Teilung durch null
					if (number2 == 0)
					{ 
						Console.WriteLine("Eine Division durch null ist nicht erlaubt.");
						return double.NaN;
					}
					Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
					return number1 / number2;
				default:
					return double.NaN;

			}
		}

		// Gibt einen Infotext aus und liest eine double Zahl so lange ein bis es funtkioniert.
		internal static double NumberInput (string text)
		{
			bool incorrectInput = true;
			double number;
			do
			{
				Console.WriteLine(text);
				incorrectInput = !double.TryParse(Console.ReadLine(), out number);
				if(incorrectInput)
					Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");

			} while (incorrectInput);
			return number;
		}

		internal static MathematicOperation MathematicOperationInput(string text)
		{
			MathematicOperation mo;
			do
			{
				// NumberInput gibt eine double Zahl zurück, diese muss in MathematicOperation gecastet werden.
				mo = (MathematicOperation) NumberInput(text);
				
				// Das wir so lange wiederholt, bis eine gültige MathematicOperation eingegeben wurde.
			} while ((int)mo < 1 || (int)mo > 4);
			return mo;
		}
	}
}
