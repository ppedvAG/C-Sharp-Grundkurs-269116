using System.Net.Http.Headers;

namespace Demo_OOP {
	class Program
	{
		static void Main(string[] args)
		{

			Person herbert = new Person("Herbert", "Mustermann", 31);
			Person sabine = new Person("Sabine", "Musterfrau");
			sabine.SetAlterFromGeburtsjahr(1990);
			herbert.setGroesse(170);
			sabine.setGroesse(160);

			Console.WriteLine(sabine.Info());
			Console.WriteLine(herbert.Info());

			for (int i = 0; i < 200; i++)
			{
				Person p = new Person();
			}

			Person.SchreibeAnzahlPersonen();

		}
	}
}