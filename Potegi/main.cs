using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj jakąś liczbę");
        string wartosc = Console.ReadLine();
        int liczba = 0;
        bool czy_OK = Int32.TryParse(wartosc, liczba);
        if (!czy_OK)
            {
                Console.WriteLine(String.Format("Czy uważasz że {0} jest poprawną liczbą", wartosc));
            }
        else
            {
                Console.WriteLine(String.Format("{0} jest poprawną liczbą, Mądrala!!!", liczba));
            }
    }
}