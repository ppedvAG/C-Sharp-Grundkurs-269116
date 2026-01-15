using System.Diagnostics;
using System.Text.Json;

namespace M012;

internal class Program
{
	static void Main(string[] args)
	{
		#region File lesen
		string readJson = File.ReadAllText(@"C:\Users\de2\OneDrive - ppedv AG\Anlagen\Schulungsunterlagen\C# Grundkurs\C-Sharp-Grundkurs-269116\Demo-Tag3\Lab-Modul13\Personen.json");
		List<Person> personen = JsonSerializer.Deserialize<List<Person>>(readJson)!;
		#endregion

		//Hier eigenen Code schreiben

		personen.Where(p => p.Alter >= 60).ToList();

		personen.Where(p => p.Job.Gehalt > 5000).ToList();

		personen.OrderBy(p=>p.Job.Gehalt).OrderBy(p=>p.Job.Titel).ToList();

		personen.Count(p => p.Vorname.Length > 10);

		personen.Where(p => p.Job.Titel == "Softwareentwickler").Average(p => p.Job.Gehalt);

		personen.Count(p => p.Hobbies.Count == 2);

		personen.Where(p => p.Alter > 50).All(p => p.Job.Gehalt > 25000 / 12);

		personen.Where(p => p.Hobbies.Contains("Radfahren") && p.Hobbies.Contains("Laufen")).ToList();
		personen.Where(p => p.Hobbies.Contains("Radfahren")).Where(p => p.Hobbies.Contains("Laufen")).ToList();

		personen.Where(p => p.Vorname.ToUpper()[0] == 'M' && p.Nachname.ToLower().StartsWith("s")).ToList();

		personen.Where(p => p.Vorname.First() == p.Nachname[0]).ToList();

		personen.Where(p => p.Alter > personen.Average(p => p.Alter)).ToList();

		personen.Where(p => p.Alter > 60 && (p.Hobbies.Contains("Laufen") || p.Hobbies.Contains("Radfahren") || p.Hobbies.Contains("Ballsport") || p.Hobbies.Contains("Fitness"))).ToList();

		personen.Select(p => p.Job.Titel).Distinct().Count();

		personen.Where(p => p.Job.Titel == "Tischler").Max(p => p.Job.Gehalt);

		personen.Where(p => p.Geburtsdatum.Year == 1977).ToList();

		personen.Select(p=> p.Vorname + " "+ p.Nachname).OrderBy(p=> p.Length).Distinct().ToList();

		personen.OrderByDescending(p => p.Job.Gehalt).Take(5).ToList();

		personen.Where(p => (int)(DateTime.Today.Subtract(p.Job.Einstellungsdatum).TotalDays / 365.25) >= 20).OrderByDescending(p=>p.Job.Einstellungsdatum).ToList();

		personen.GroupBy(p => p.Vorname).ToDictionary(p => p.Key, e => e.Count()).OrderByDescending(p => p.Value).ToDictionary();
			
		personen.GroupBy(p=>p.Job.Titel).ToDictionary(p=>p.Key, p=>p.Max(p=>p.Job.Gehalt)).OrderBy(p=>p.Key).ToDictionary();
		
		personen.SelectMany(p => p.Hobbies).GroupBy(h => h).ToDictionary(h => h.Key, h => h.Count()).OrderByDescending(h => h.Value).Take(1).ToDictionary();

		personen.GroupBy(p => p.Job.Titel).ToDictionary(p => p.Key, p => p.OrderByDescending(p => p.Job.Gehalt).Take(3).ToList());
	}
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////