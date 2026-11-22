int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
 
int suma = 0;
int licznik = 0;
 
Console.WriteLine("Liczba tur: " + zlotoWTurach.Length);
 
Console.WriteLine("Zloto w poszczegolnych turach:");
 
for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine("Tura " + (i + 1) + ": " + zlotoWTurach[i]);
 
    suma = suma + zlotoWTurach[i];
 
    if (zlotoWTurach[i] >= 10)
    {
        licznik++;
    }
}
 
double srednia = (double)suma / zlotoWTurach.Length;
 
Console.WriteLine("Suma zlota: " + suma);
Console.WriteLine("Srednia zlota: " + srednia);
Console.WriteLine("Liczba tur z minimum 10 zlota: " + licznik);
 
Console.WriteLine("Zloto od konca:");
 
for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
    Console.WriteLine(zlotoWTurach[i]);
}
 
Console.WriteLine("Wyswietlanie przez foreach:");
 
foreach (int zloto in zlotoWTurach)
{
    Console.WriteLine(zloto);
}