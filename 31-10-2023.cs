using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
            //Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić
            //odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić
            //wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. Program powinien działać w
            //pętli, dopóki użytkownik nie wpisze q.Użyj instrukcji try-catch-finally do obsługi wyjątków.
            double n;
            string a;
            bool x = false;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (!x)
            {
                try
                {
                    Console.WriteLine("Podaj liczbę lub q jeśli chcesz wyjść: ");
                    a= Console.ReadLine();
                    if (a == "q")
                    {
                        Console.WriteLine("Dziękujemy za skorzystanie z programu.");
                        x =true;
                        break;
                    }
                    n = double.Parse(a);
                    if (n < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new ArgumentOutOfRangeException("Liczba musi być dodatnia.");
                        Console.ResetColor();
                    }
                    Console.WriteLine(n * n);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadzono nieprawdiłowe dane.");
                    Console.ResetColor();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wykryto błąd: " + e.Message);
                    Console.ResetColor();
                }
            }
        }
    }
}
