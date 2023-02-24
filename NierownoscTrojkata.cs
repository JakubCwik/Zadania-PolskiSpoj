using System;

namespace NierownoscTrojkata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dane;
            //while ((dane = Console.ReadLine()) != null)
            while ((dane = Console.ReadLine()) != "")
            {
                string[] wymiary = dane.Split(' ');
                for(int i = 0; i < wymiary.Length; i++)
                {
                    wymiary[i] = wymiary[i].Replace('.', ',');
                }
                double[] liczby = new double[3];
                
                for(int i = 0; i < wymiary.Length; i++)
                {
                    liczby[i] = Convert.ToDouble(wymiary[i]);
                }
                Array.Sort(liczby);

                if (liczby[2] < liczby[1] + liczby[0])
                {
                    Console.WriteLine("1");
                }
                else if(liczby[0] <=0 || liczby[1]<=0 || liczby[2]<=0)
                {
                    Console.WriteLine("0");
                }
                else { Console.WriteLine("0"); }
            }
        }
    }
}
