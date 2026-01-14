using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
	internal class Admin : Person
	{
		public string AdminCode { get; set; }
		
		// Konstruktor
		public Admin(string vorname, string nachname, string adminCode)
			: base(vorname, nachname)
		{
			AdminCode = adminCode;
		}

		public override string Info()
		{
			return base.Info() + $", AdminCode: {AdminCode}";
		}
	}
}
