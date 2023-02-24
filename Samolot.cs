using System;

namespace Samolot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dane = Console.ReadLine();
            string[] tabDanych = dane.Split(" ");
            int n1 = int.Parse(tabDanych[0]);
            int k1 = int.Parse(tabDanych[1]);
            int n2 = int.Parse(tabDanych[2]);
            int k2 = int.Parse(tabDanych[3]);            
            Console.WriteLine((n1 * k1) + (n2 * k2));
        }
    }
}
