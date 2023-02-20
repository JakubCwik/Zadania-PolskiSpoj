using System;

namespace CALC
{
     class Program
     {
        public static void Main()
        {
            string tekst;
                //while ((tekst = Console.ReadLine()) != null)
                while ((tekst = Console.ReadLine()) != "")
                {
                string[] tab = tekst.Split(' ');
                int a = int.Parse(tab[1]);
                int b = int.Parse(tab[2]);
                switch(tab[0])
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine(a % b);
                        break;
                }
                }
        }
     }
}
