using System;

namespace Podzielnosc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string wynik = "";
                string dane = Console.ReadLine();
                string[] tab = dane.Split(' ');
                int n = int.Parse(tab[0]);
                if (n > 100000) { return; }
                int x = int.Parse(tab[1]);
                int y = int.Parse(tab[2]);

                for(int j =1; j< n; j++)
                {
                    if (j % x == 0 && j % y != 0)
                    {
                        wynik += j.ToString() + " ";
                    }
                }
                Console.WriteLine(wynik);
            }
        }
    }
}
