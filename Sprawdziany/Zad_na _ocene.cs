using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gr 2
            //Zad.1
            //Napisz program który oblicza pole prostokąta
            bool n = false;
            while (n == false)
            {
                try
                {
                    Console.WriteLine("Podaj pierwszy bok: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugi bok: ");
                    double y = double.Parse(Console.ReadLine());
                    if(x<=0 || y<=0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception("Podana wartosc musi byc wieksza od 0.");
                        Console.ResetColor();
                    }
                    double wynik = x * y;
                    Console.WriteLine($"{x}*{y}={wynik}");
                    n = true;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Przekroczono zakres wartosci zmiennej. Podana wartosc musi sie miescic pomiedzy {double.MinValue} a {double.MaxValue}");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podano nie poprawne dane.");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Blad: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }
    }
}
