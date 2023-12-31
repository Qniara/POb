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
            //double n;
            //string a;
            //bool x = false;
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //while (!x)
            //{
            //    try
            //    {
            //        Console.WriteLine("Podaj liczbę lub q jeśli chcesz wyjść: ");
            //        a= Console.ReadLine();
            //        if (a == "q")
            //        {
            //            Console.WriteLine("Dziękujemy za skorzystanie z programu.");
            //            x =true;
            //            break;
            //        }
            //        n = double.Parse(a);
            //        if (n < 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            throw new ArgumentOutOfRangeException("Liczba musi być dodatnia.");
            //            Console.ResetColor();
            //        }
            //        Console.WriteLine("Pierwiastek z liczby wynosi: " + Math.Sqrt(n));
            //    }
            //    catch (FormatException)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Wprowadzono nieprawdiłowe dane.");
            //        Console.ResetColor();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Wykryto błąd: " + e.Message);
            //        Console.ResetColor();
            //    }
            //}

            //Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
            //Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. 
            //Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek
            //ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat.Jeśli użytkownik wprowadzi nieprawidłowe dane,
            //program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych.Program powinien
            //działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest
            //ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
            //Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o
            //ponowne wprowadzenie liczby.
            Console.OutputEncoding = Encoding.UTF8;
            int[] T = new int[5];
            string n;
            int a;
            do
            {
                for (int i = 0; i < T.Length; i++)
                {
                    try
                    {
                        Console.WriteLine("Podaj liczbę:");
                        n = Console.ReadLine();
                        if (n == "q")
                        {
                            break;
                        }
                        int x = int.Parse(n);
                        T[i] = x;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wprowadzono niepoprawne dane.");
                        Console.ResetColor();
                        i--;
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wykryto błąd: " + e.Message);
                        Console.ResetColor();
                        i--;
                    }
                }
                try
                {
                    Console.WriteLine("Podaj które miejsce z tablicy chcesz wyświetlić: ");
                    n = Console.ReadLine();
                    if (n == "q")
                    {
                        break;
                    }
                    a = int.Parse(n);
                    if (a > 4 || a < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception("W tablicy nie ma miejsca o podanej wartości.");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Wartość na podanym miejscu w tablicy to: " + T[a]);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadzono niepoprawne dane.");
                    Console.ResetColor();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wykryto błąd: " + e.Message);
                    Console.ResetColor();
                }
            } while (true);
        }
    }
}
