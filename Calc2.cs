using System;

namespace CALC2
{
    internal class Program
    {
        public static void Main()
        {
            int[] tab = new int[10];
            string tekst;
            //while((tekst = Console.ReadLine()) != null)
            while ((tekst = Console.ReadLine()) != "")
                {
                string[] liczby = tekst.Split(' ');
                int a = int.Parse(liczby[1]);
                int b = int.Parse(liczby[2]);

                if (liczby[0] == "z")
                {
                    tab[a] = b;
                }
                else
                {
                    switch (liczby[0])
                    {
                        case "+":
                            Console.WriteLine(tab[a] + tab[b]);
                            break;
                        case "-":
                            Console.WriteLine(tab[a] - tab[b]);
                            break;
                        case "*":
                            Console.WriteLine(tab[a] * tab[b]);
                            break;
                        case "/":
                            Console.WriteLine(tab[a] / tab[b]);
                            break;
                        default:
                            Console.WriteLine(tab[a] % tab[b]);
                            break;
                    }
                }
            }
        }
    }
}
