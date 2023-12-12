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
        }
    }
}
