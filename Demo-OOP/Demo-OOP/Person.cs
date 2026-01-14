using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP
{
	internal class Person
	{

		// Statisches Member: anzahl erzeugter Personen-Objekte
		public static int AnzahlPersonen { get; private set; } = 0;
		public string Vorname { get; private set; }
		public string Nachname { get; set; }

		
		// Statische Methode zur Ausgabe der Anzahl erzeugter Personen-Objekte
		public static void SchreibeAnzahlPersonen()
		{
			//Console.WriteLine(Vorname); Fehler: Statische Methode kann nicht auf nicht-statische Member zugreifen

			Console.WriteLine($"Anzahl erzeugter Personen-Objekte: {AnzahlPersonen}");
		}

		// privates Feld Alter mit Initialwert 0
		private int alter = 0;
		// öffentliche Eigenschaft Alter (zum Lesen und Schreiben des Feldes alter)
		public int Alter 
		{
			get
			{
				return alter;
			}
			set
			{
				if(value >= 0)
				{
					alter = value;
				}
			}
		}

		private double groesse = 0;

		public double getGroesse() { 
			return groesse; 
		}
		public void setGroesse(double value) 
		{ 
			if(value >= 0)
			{
				groesse = value; 
			}
		}

		// Konstruktor
		public Person(string vorname, string nachname)
		{
			Vorname = vorname;
			Nachname = nachname;
			AnzahlPersonen++; // Erhöhen des statischen Members bei jeder Objekterzeugung
		}

		// Konstuktorüberladung mit Alter
		public Person(string vorname, string nachname, int alter): this(vorname, nachname)
		{
			// this.alter = alter; 
			// Aufruf der Set Methode - mit Validierung
			Alter = alter; 
		}

		// Leeren Konstruktor
		public Person() : this("Max", "Mustermann")
		{
		}

		// Methode um Alter anhand eines Geburtsjahres zu setzen
		public void SetAlterFromGeburtsjahr(int geburtsjahr)
		{
			Alter = DateTime.Now.Year - geburtsjahr;
		}

		// Info-Methode
		public virtual string Info()
		{
			return $"Name: {Vorname} {Nachname}, Alter: {Alter}, Größe: {groesse}cm";
		}

		

		~Person()
		{
			AnzahlPersonen--; // Verringern des statischen Members bei jeder Objektlöschung
			Console.WriteLine("DESTRUKTOR aufgerufen");
		}
	}
}
