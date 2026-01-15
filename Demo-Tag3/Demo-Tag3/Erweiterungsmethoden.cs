using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Tag3
{
	internal static class Erweiterungsmethoden
	{
		// Erweiterungsmethode für String ohne Lamda Expression
		//internal static int CountCapitalCharecters(this string input)
		//{
		//	int count = 0;
		//	foreach (char c in input)
		//	{
		//		if (char.IsUpper(c))
		//		{
		//			count++;
		//		}
		//	}
		//	return count;
		//}

		// Erweiterungsmethode für String mit Lamda Expression
		internal static int CountCapitalCharecters(this string input) => input.Count(e => char.IsUpper(e));
	}
}
