using System.Xml;

namespace cw_17._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double a;
            //Console.WriteLine("Podaj a: ");
            //if (double.TryParse(Console.ReadLine(), out a))
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Błędne dane");
            //}

            Console.Write("Podaj a: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Wpisz prawidłowe dane.");
            }
            Console.Write("Podaj b: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Wpisz prawidłowe dane.");
            }
            Console.Write("Podaj c: ");
            double c;
            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Wpisz prawidłowe dane.");
            }
            if (IsTriangle(a, b, c))
            {
                Console.WriteLine($"Pole trojkata o bokach {a}, {b} i {c} wynosi: {Pole(a,b,c)}");
            }
            else
            {
                Console.WriteLine("Podane dlugosci nie tworza trojboka.");
            }
            bool IsTriangle(double a, double b, double c)
            {
                if(a+b>c && b+c>a && c + a > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            double Pole(double a, double b, double c)
            {
                double p = (a + b + c) / 2;
                double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return pole;
            }
        }
    }
}
