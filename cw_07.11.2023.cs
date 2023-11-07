using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TABLICE

            //initalizacja tablicy podczas deklaracji
            //int[] tabInt = { 1, 2, 3, 4 };//deklaracja tablicy 
            //Console.WriteLine(tabInt[0]);//wyswietla 1 element tablicy
            //Console.WriteLine(tabInt[tabInt.Length - 1]);//wyswietla ostatni element

            //deklaracja tablicy
            //int[] tabInt2 = new int[5];
            //tabInt2[0] = 1;
            //tabInt2[1] = 2;
            //tabInt2[2] = 3;
            //tabInt2[3] = 4;
            //tabInt2[4] = 5;
            //foreach (int i in tabInt2)
            //{
            //    Console.WriteLine(i);
            //}

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.Następnie program 
            //wyświetla sumę wszystkich elementów tablicy
            //int[] T = new int[5];
            //int suma = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Podaj liczbe: ");
            //    int x = int.Parse(Console.ReadLine());
            //    T[i] = x;
            //    suma = suma + x;
            //}
            //Console.WriteLine(suma);

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.Następnie program
            //wyświetla sumę wszystkich elementów tablicy. W celu zabezpieczenia programu przed niepoprawnymi danymi
            //wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest
            //liczbą całkowitą.Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i
            //poprosi o ponowne wprowadzenie liczby.
            int[] T = new int[5];
            int n= 0;
            int suma = 0;
            while (n == 5)
            {
                int x = Console.ReadLine();

            }

            //Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
            //Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. 
            //Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException
            //i wyświetlić odpowiedni komunikat.Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek
            //FormatException i poprosić o ponowne wprowadzenie danych.Program powinien działać w pętli, dopóki użytkownik nie
            //wpisze q. Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek
            //ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane,
            //program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.
        }
    }
}
