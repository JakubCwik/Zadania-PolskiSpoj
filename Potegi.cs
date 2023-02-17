using System;

namespace Potegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            for (int i = 0; i < D; i++)
            {
                string tekst = Console.ReadLine();
                string[] liczby = tekst.Split(' ');
                int podstawa = int.Parse(liczby[0]);
                podstawa = podstawa % 10;
                int wykladnik = int.Parse((liczby[1]));
                if (wykladnik > 0)
                {
                    if (wykladnik % 4 == 0)
                    {
                        wykladnik = 4;
                    }
                    else
                    {
                        wykladnik = wykladnik % 4;
                    }


                    int wynik = podstawa;
                    for (int j = 1; j < wykladnik; j++)
                    {
                        wynik *= podstawa;
                    }
                    Console.WriteLine(wynik%10);
                }
                else
                {
                    Console.WriteLine(1);
                }


            }
        }
    }
}
