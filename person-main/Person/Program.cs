using System;

class Program
{

    static void Main()
    {

        Osoba osoba = new Osoba("jamajczyk", "bomba", 'M', new DateTime(2007, 10, 6));

        Console.WriteLine($"Imię: {osoba.Imie}, Nazwisko: {osoba.Nazwisko}, Płeć: {osoba.Plec}, Data Urodzenia: {osoba.DataUrodzenia.ToShortDateString()}");
    }
}
