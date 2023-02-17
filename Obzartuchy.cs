using System;

namespace Obzartuchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zestawyTestowe = int.Parse(Console.ReadLine());           
            int sekundyDoba = 86400;
            for (int i = 0; i < zestawyTestowe; i++)
            {
                int ileZje = 0;
                string dane = Console.ReadLine();
                string[] nm = dane.Split(" ");
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                if(n<1 || n > 10000) { return;}
                if(m<1 || m > 1000000000) { return;}
                int[] czas = new int[n];

                for (int j = 0; j < n; j++)
                {
                    czas[j] = int.Parse(Console.ReadLine());
                    if (czas[j] < 1 || czas[j] > 100000) { return; }
                    ileZje = ileZje+(sekundyDoba / czas[j]);
                }
                int wynik = ileZje / m;
                if(ileZje%m>0)
                {
                    wynik++;
                }
                Console.WriteLine(wynik);
            }
        }
    }
}
