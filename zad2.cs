Dictionary<string, int> cennik = new Dictionary<string, int>();

cennik.Add("Miecz", 100);
cennik.Add("Tarcza", 75);
cennik.Add("Mikstura", 20);


Console.WriteLine("Poczatkowy cennik:");

foreach (KeyValuePair<string, int> przedmiot in cennik)
{
    Console.WriteLine(przedmiot.Key + " - " + przedmiot.Value + " zlota");
}

string nowyPrzedmiot;

while (true)
{
    Console.Write("\nPodaj nazwe nowego przedmiotu: ");
    nowyPrzedmiot = Console.ReadLine() ?? "";
    nowyPrzedmiot = nowyPrzedmiot.Trim();

    if (string.IsNullOrWhiteSpace(nowyPrzedmiot))
    {
        Console.WriteLine("Nazwa nie moze byc pusta.");
        continue;
    }

    if (cennik.ContainsKey(nowyPrzedmiot))
    {
        Console.WriteLine("Taki przedmiot juz istnieje. Podaj inna nazwe.");
        continue;
    }

    break;
}

int cena;

while (true)
{
    Console.Write("Podaj cene przedmiotu: ");
    string wpisanaCena = Console.ReadLine() ?? "";

    if (int.TryParse(wpisanaCena, out cena) && cena >= 0)
    {
        break;
    }

    Console.WriteLine("Cena musi byc nieujemna liczba calkowita.");
}


cennik.Add(nowyPrzedmiot, cena);

Console.WriteLine("\nDodano przedmiot do cennika.");


string szukanyPrzedmiot;

while (true)
{
    Console.Write("\nPodaj nazwe przedmiotu do wyszukania: ");
    szukanyPrzedmiot = Console.ReadLine() ?? "";
    szukanyPrzedmiot = szukanyPrzedmiot.Trim();

    if (!string.IsNullOrWhiteSpace(szukanyPrzedmiot))
    {
        break;
    }

    Console.WriteLine("Nazwa nie moze byc pusta.");
}


if (cennik.ContainsKey(szukanyPrzedmiot))
{
    Console.WriteLine("Przedmiot znaleziony!");
    Console.WriteLine("Cena: " + cennik[szukanyPrzedmiot] + " zlota");
}
else
{
    Console.WriteLine("Nie znaleziono takiego przedmiotu.");
}


Console.WriteLine("\nAktualny cennik:");

foreach (KeyValuePair<string, int> przedmiot in cennik)
{
    Console.WriteLine(przedmiot.Key + " - " + przedmiot.Value + " zlota");
}
