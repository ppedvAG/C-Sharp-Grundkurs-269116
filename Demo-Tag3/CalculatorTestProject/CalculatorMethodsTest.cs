using Demo_Tag3;

namespace CalculatorTestProject
{
	[TestClass]
	public sealed class CalculatorMethodsTest
	{

		// Jede TestMethode soll nur eine Sache testen!

		// 2 Zahlen addieren
		[TestMethod]
		public void CalculateAdd2Numbers()
		{
			for(int i = -10; i <= 10; i++)
			{
				for(int j = -10; j <= 10; j++)
				{
					double number1 = i + 0.5;
					double number2 = j + 0.5;
					Assert.AreEqual(number1 + number2, CalculatorMethods.Calculate(number1, number2, CalculatorMethods.MathematicOperation.Addition));
					
				}
			}
		}

		[TestMethod]
		public void CalculateSubtract2Numbers()
		{
			for (int i = -10; i <= 10; i++)
			{
				for (int j = -10; j <= 10; j++)
				{
					double number1 = i + 0.5;
					double number2 = j + 0.5;
					Assert.AreEqual(number1 - number2, CalculatorMethods.Calculate(number1, number2, CalculatorMethods.MathematicOperation.Subtraktion));

				}
			}
		}

		[TestMethod]
		public void CalculateMultiply2Numbers()
		{
			for (int i = -10; i <= 10; i++)
			{
				for (int j = -10; j <= 10; j++)
				{
					double number1 = i + 0.5;
					double number2 = j + 0.5;
					Assert.AreEqual(number1 * number2, CalculatorMethods.Calculate(number1, number2, CalculatorMethods.MathematicOperation.Multiplikation));

				}
			}
		}

		[TestMethod]
		public void CalculateDivide2Numbers()
		{
			for (int i = -10; i <= 10; i++)
			{
				for (int j = -10; j <= 10; j++)
				{
					double number1 = i + 0.5;
					double number2 = j + 0.5;
					Assert.AreEqual(number1 / number2, CalculatorMethods.Calculate(number1, number2, CalculatorMethods.MathematicOperation.Division));

				}
			}
		}

		// Test für Exception bei Division durch 0
		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void CalcualteDivideByZeroException()
		{
			CalculatorMethods.Calculate(10,0,CalculatorMethods.MathematicOperation.Division);
		}

		// Test der immer Fehl schlägt
		//[TestMethod]
		//public void FailingTest()
		//{
		//	Assert.AreEqual(10, CalculatorMethods.Calculate(5,5,CalculatorMethods.MathematicOperation.Multiplikation));
		//}
	}
}
