using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12._23r
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int,string> slownik = new Dictionary<int,string>();
            //slownik.Add(1, "Franek");
            //slownik.Add(2, "Anna");
            //slownik.Add(3, "Tomasz");

            //foreach (var item in slownik)
            //{
            //    Console.WriteLine($"{item.Value}");
            //}
            //Console.WriteLine();

            ////Tworzenie słownika, który przechowuje łańcuchy jako kluczw i liczby jako wartości
            //Dictionary<string, int> slownik1 = new Dictionary<string, int>();
            ////Dodajemy kilka par klucz-wartość
            //slownik1.Add("Jeden",1);
            //slownik1.Add("Dwa", 2);
            //slownik1.Add("Trzy", 3);
            ////Wyświetlenie zawartości słownika za pomocą pętli foreach
            //foreach(var item1 in slownik1) //albo (KeyValuePair<string, int> item1 in slownik1)
            //{
            //    Console.WriteLine($"Klucz: {item1.Key}, Wartość: {item1.Value}");
            //}

            //Utwórz słownik, który może przechowywać łańcuchy jako klucze i wartości
            //Dictionary<string, string> capital = new Dictionary<string, string>();
            //Dodaj kilka par klucz-wartość do słownika za pomocą składni inicjalizatora kolekcji 
            //capital = new Dictionary<string, string>
            //{
            //    {"Polska", "Warszawa"},
            //    {"Polska", "Warszawa"},
            //    {"Polska", "Warszawa"},
            //    {"Włochy", "Rzym"},
            //};

            //Słownik telefonów
            //Dictionary<string, string>phones=new Dictionary<string, string>();
            //phones.Add("+48 123 456 789", "Katarzyna");
            //phones.Add("+48 123 444 789", "Tomasz");
            //phones.Add("+48 123 581 789", "Anna");
            //foreach(KeyValuePair<string, string> pair in phones)
            //{
            //    Console.WriteLine($"Nr tel: {pair.Key}\nOsoba: {pair.Value}\n\n");
            //}
            //Console.WriteLine();

            //Zwierzęta
            //Dictionary<string, string>animals=new Dictionary<string, string>();
            //animals = new Dictionary<string, string>()
            //{
            //    { "kot", "pupa"},
            //    {"koń", "dupa" }
            //};
            //foreach(var animal in animals)
            //{
            //    Console.WriteLine($"Zwierze: {animal.Key}\nOdglos: {animal.Value}\n\n");
            //}

            //Kolory
            //Dictionary<string, string>colors= new Dictionary<string, string>();
            //colors = new Dictionary<string, string>()
            //{
            //    {"czerwony","#FF0000" },
            //    {"zielony","#00FF00" },
            //    {"niebieski","#0000FF" }
            //};
            //foreach(var color in colors)
            //{
            //    Console.WriteLine($"Kolor: {color.Key}\nW RGB: {color.Value}\n");
            //}

            //Popros użytkownika o podanie par klusz i wartosc
            //Dictionary<string, string> data = new Dictionary<string, string>();
            //Console.WriteLine("Podaj ile chcesz wprowadzić: ");
            //int n = int.Parse(Console.ReadLine());
            //for(int i=0; i < n;i++)
            //{
            //    Console.Write("Podaj klucz: ");
            //    string klucz = Console.ReadLine();
            //    Console.Write("Podaj wartosc: ");
            //    string wartosc = Console.ReadLine();
            //    data.Add(klucz, wartosc);
            //}
            //foreach(var item in data)
            //{
            //    Console.WriteLine($"Klucz: {item.Key}\nWartosc: {item.Value}\n");
            //}

            //Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w
            //którym kluczem jest liczba, a wartością jest jej częstotliwość występowania na liście.
            //Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
            //Przykład: dla listy[1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik
            //{ 1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.Napisz program, który wczytuje od użytkownika ciąg znaków,
            //próbuje przekonwertować go na liczbę całkowitą za pomocą metody TryParse, a następnie wyświetla
            //wynik na konsoli. Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i
            //informację, że jest to poprawna liczba całkowita. Jeśli konwersja się nie powiedzie, program
            //powinien wyświetlić informację, że podany ciąg znaków nie jest poprawną liczbą całkowitą.
            //Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą
            //całkowitą”.Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą
            //całkowitą”.
        }
        Dictionary<int, int> funkcja(List<int> Lista)
        {
            Dictionary<int, int> slownik = new Dictionary<int, int>();
            List<int> Lista2 = new List<int>();
            int x = 0;
            for(int i = 0; i < Lista.Count; i++)
            {
                for(int j = 0; j < Lista.Count; j++)
                {
                    if (i == j)
                    {
                        x++;
                    }
                }
                Lista2.Add(x);
            }
            for(int i=0; i < Lista2.Count; i++)
            {
                slownik.Add(Lista[i], Lista2[i]);
            }
            return slownik;
        }
    }
}
