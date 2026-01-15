namespace Demo_Tag3
{
	class Program
	{
		static void Main(string[] args)
		{
			// Fehlerbehandlung
			Console.WriteLine("Zahl eingeben");

			try
			{
				int number = int.Parse(Console.ReadLine());
			}
			catch (FormatException e)
			{
				Console.WriteLine("Falsches Format, bitte eine Ganze Zahl eingeben");
			}
			catch (OverflowException e)
			{
				Console.WriteLine("Zahl zu groß");
			}
			catch (ArgumentNullException e) // Wird nie Erreicht weil ReadLine nie Null liefert
			{
				Console.WriteLine("Parameter von Parse darf nicht Null sein");
			} finally
			{
				Console.WriteLine("Wird immer angezeigt");
			}

			// NumberInput mit try catch
			try
			{
				double number = CalculatorMethods.NumberInput("Eine Zahl eingeben:");
			}
			catch (IncorrectInputException e)
			{
				Console.WriteLine(e.Message);
			}


			// Calculate mit Division durch 0 soll Exception werfen
			try
			{
				double result = CalculatorMethods.Calculate(12, 0, CalculatorMethods.MathematicOperation.Division);
			} catch(DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}