using System;

namespace Flamaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            for (int i = 0; i < C; i++)
            {
                string tekst = Console.ReadLine();
                string wynik = "";
                int licznik = 1, j = 0;
                while(j<tekst.Length)
                {
                    licznik = 1;
                    char ObecnyZnak = tekst[j];
                    j++;
                    for(; j<tekst.Length && tekst[j] == ObecnyZnak; j++)
                    {
                        licznik++;
                    }
                    if(licznik == 1)
                    {
                        wynik += ObecnyZnak.ToString();
                    }
                    else if(licznik==2)
                    {
                        wynik += ObecnyZnak.ToString();
                        wynik += ObecnyZnak.ToString();
                    }
                    else
                    {
                        wynik += ObecnyZnak.ToString() + licznik.ToString();
                    }
                }
                Console.WriteLine(wynik);
            }
        }
            
    }
}
