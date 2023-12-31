using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            //int[] T = new int[5];
            //int n= 0;
            //int i = 0;
            //int suma = 0;
            //while (i!=5)
            //{
            //    Console.Write("Podaj liczbe: ");
            //    while (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Podaj prawidlowe dane.");
            //        Console.Write("Podaj liczbe: ");
            //    }
            //    suma = suma + n;
            //    T[i] = n;
            //    i++;
            //}
            //Console.WriteLine("Suma podanych liczb to: " + suma);

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla
            //sumę wszystkich elementów tablicy.Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers. Użyj pętli for, aby
            //pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers. Wyświetl na ekranie komunikat, który
            //prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i
            //zweryfikować. Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca
            //ją. Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne
            //wprowadzenie liczby. Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą
            //całkowitą i przypisać ją do zmiennej input. Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje
            //tablicę liczb całkowitych i zwraca ich sumę. Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers
            //i zwrócić sumę. Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum. Wyświetl na ekranie
            //komunikat, który pokazuje sumę podanych liczb.
            //int GetIntegerFromUser()
            //{
            //    int n;
            //    Console.Write("Podaj liczbe: ");
            //    while (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Podaj prawidlowa wartosc.");
            //        Console.Write("Podaj liczbe: ");
            //    }
            //    return n;
            //}
            //int CalculateSum(int[] T)
            //{
            //    int sum = 0; ;
            //    foreach(int t in T)
            //    {
            //        sum += t;
            //    }
            //    return sum;
            //}
            //int[] numbers = new int[5];
            //int suma = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = GetIntegerFromUser();
            //}
            //suma = CalculateSum(numbers);
            //Console.WriteLine("Suma podanych liczb wynosi: " + suma);

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
