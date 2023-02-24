using System;

namespace OdwracanieWyrazow
{
     class Program
    {
        static void Main()
        {
            string wyraz;
            //while ((wyraz = Console.ReadLine()) != null)
            while ((wyraz = Console.ReadLine()) != "")
            {
                string wynik = "";
                if (wyraz.Length > 1000) { return; }
                for (int i = wyraz.Length - 1; i >= 0; i--)
                {
                    wynik += wyraz[i];
                }
                Console.WriteLine(wynik);
            }
        }
    }
}
