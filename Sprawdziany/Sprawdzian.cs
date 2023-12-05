using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sprawdzian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //grupa 2
            //Napisz program, który:
            //Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca
            //tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z
            //klawiatury
            //Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość
            //pola kwadratu o boku a.Wzór na pole kwadratu to:
            //P = a2
            //Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość
            //obwodu kwadratu o boku a.Wzór na obwód kwadratu to:
            //O = 4a
            //W funkcji Main:
            //Deklaruje zmienną n i przypisuje jej wartość 5.
            //Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
            //Wyświetla na ekranie zawartość tablicy tablica.
            //Dla każdego elementu tablicy tablica:
            //Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
            //Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
            //Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
            //Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola
            //i obwodu kwadratu
            int n2 = 5;
            int[] Tablica = UtworzTabliceLiczb(n2);
            int[] Pole = new int[n2];
            int[] Obwod = new int[n2];
            for (int i2 = 0; i2 < n2; i2++)
            {
                Pole[i2] = ObliczPole(Tablica[i2]);
                Obwod[i2] = ObliczObwod(Tablica[i2]);
                Console.WriteLine($"Pole kwadratu o dlugosci boku {Tablica[i2]} wynosi: {Pole[i2]}");
                Console.WriteLine($"Obwod kwadratu o dlugosci boku {Tablica[i2]} wynosi: {Obwod[i2]}");
                Console.WriteLine();
            }
            Funkcja(Tablica);
        }
        static int[] UtworzTabliceLiczb(int n2)
        {
            int[] T2 = new int[n2];
            int i2 = 0;
            int x2;
            while (i2 < n2)
            {
                Console.WriteLine("Podaj liczbe od 1 do 10: ");
                while (!int.TryParse(Console.ReadLine(), out x2))
                {
                    Console.WriteLine("Podano niepoprawną wartosc.");
                }
                if (x2 > 0 && x2 < 11)
                {
                    T2[i2] = x2;
                    i2++;
                }
                else
                {
                    Console.WriteLine("Podana liczba musi byc od 1 do 10.");
                }
            }
            return T2;
        }
        static int ObliczPole(int a2)
        {
            return a2 * a2;
        }
        static int ObliczObwod(int a2)
        {
            return 4 * a2;
        }
        public static void Funkcja(int[] T)
        {
            Console.WriteLine("Podaj indeks: ");
            int n2;
            while ((!int.TryParse(Console.ReadLine(), out n2)) || n2 < 0 || n2 > 4)
            {
                Console.WriteLine("Podano niepoprawna wartosc.");
            }
            Console.WriteLine($"Pole kwadratu o dlugosci boku {T[n2]} wynosi: {ObliczPole(T[n2])}");
            Console.WriteLine($"Obwod kwadratu o dlugosci boku {T[n2]} wynosi: {ObliczObwod(T[n2])}");
        }
    }
}
