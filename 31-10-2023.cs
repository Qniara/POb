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
            bool x = false;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (x == false)
            {
                try
                {
                    Console.WriteLine("Podaj liczbę: ");
                    n = double.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        x=true;
                    }
                    Console.WriteLine(n * n);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono nieprawdiłowe dane.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Liczba musi być dodatnia.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wykryto błąd: " + e.Message);
                }
            }
        }
    }
}
