using System;

namespace ZabawneDodawanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wynik = 0;
            int licznik = 0;
            int t;
            int liczbaSprawdzona;
            bool czyZakonczono;

            string tt = Console.ReadLine();
            bool czyKonwertuje = int.TryParse(tt, out t);
            if (t>80)
            {
                return;
            }
            for(int i = 0; i < t; i++)
            {
                string liczba = Console.ReadLine();
                czyKonwertuje = int.TryParse(liczba, out liczbaSprawdzona);
                if(!czyKonwertuje || liczbaSprawdzona<1 || liczbaSprawdzona>80)
                {
                    return;
                }
                czyZakonczono = false;
                licznik = 0;
                while (czyZakonczono != true)
                {
                    string odwroconaLiczba = "";
                    for (int j = liczba.Length - 1; j >= 0; j--)
                    {
                        odwroconaLiczba += liczba[j];
                    }

                    if (odwroconaLiczba == liczba)
                    {
                        Console.WriteLine(liczba + " " + licznik);
                        czyZakonczono = true;
                    }
                    else
                    {
                        wynik = int.Parse(liczba) + int.Parse(odwroconaLiczba);
                        licznik++;
                        liczba = wynik.ToString();
                    }
                }
            }
        }
    }
}