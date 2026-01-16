using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	//vgl. Schiff
	public class Flugzeug : Fahrzeug
	{
		public int MaxFlughoehe { get; set; }

		public Flugzeug(string name, int maxGeschwindigkeit, double preis, int maxFlughoehe) : base(name, maxGeschwindigkeit, preis)
		{
			this.MaxFlughoehe = maxFlughoehe;
		}

		public override string Info()
		{
			return "Das Flugzeug " + base.Info() + $" Es kann bis auf {this.MaxFlughoehe}m aufsteigen.";
		}

		//public override void Hupen()
		//{
		//	Console.WriteLine("Flugzeug "+Name+" Hupt: Biep Biep!");
		//}
	}
}
