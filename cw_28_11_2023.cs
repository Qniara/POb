using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tablice dwuwymiarowe
            //int[,] ints = new int[4, 3];
            //Console.WriteLine(ints.Rank);//podaje ilu wymiarowa tablica
            //Console.WriteLine(ints.GetLength(0));//podaje dlugosc tablicy na pierwszym wymiarze
            //Console.WriteLine(ints.GetLength(1));//podaje dlugosc tablicy na drugim wymiarze

            //for(int i=0; i<ints.GetLength(0); i++)
            //{
            //    for(int j=0; j < ints.GetLength(1); j++)
            //    {
            //        Console.Write($"ints[{i},{j}]={ints[i,j]}  ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,,] cubs = new int[4, 3, 2];
            //for (int i = 0; i < cubs.GetLength(0); i++)
            //{
            //    Console.WriteLine($"cubs[{i}]");
            //    for (int j = 0; j < cubs.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"\tcubs[{i},{j}]");
            //        for (int k = 0; k<cubs.GetLength(2); k++)
            //        {
            //            Console.Write($"\t\tcubs[{i},{j},{k}]={cubs[i, j, k]}  ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for(int j=0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"matrix[{i},{j}]={matrix[i,j]}");
            //    }
            //    Console.WriteLine();
            //}

            //double[,,] cube1 = new double[,,] { { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 } }, { { 7.0, 8.0, 9.0 }, { 10.0, 11.0, 12.0 } } };
            //for (int i = 0; i < cube1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"cube1[{i}]");
            //    for (int j = 0; j < cube1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"\tcube1[{i},{j}]");
            //        for (int k = 0; k < cube1.GetLength(2); k++)
            //        {
            //            Console.Write($"\t\tcube1[{i},{j},{k}]={cube1[i, j, k]}  ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            //------------------------------------------------------------------------------------------------------------------------------------

            //Napisz program w języku C#, który realizuje następujące funkcjonalności:
            //Program wczytuje z klawiatury liczbę n i tworzy tablicę dwuwymiarową o wymiarach n x n.
            //Program wypełnia tablicę liczbami losowymi z zakresu od 1 do 100 i wyświetla jej zawartość na ekranie.
            //Program oblicza i wyświetla sumę elementów na głównej przekątnej tablicy.
            //Program posiada menu, które umożliwia użytkownikowi wybór jednej z pięciu funkcji statycznych, które realizują poszczególne 
            //kroki zadania.Menu jest wyświetlane na początku programu i po każdym wykonaniu funkcji.Menu ma następującą postać:
            //Wybierz funkcję statyczną:
            //1.WczytajLiczbe
            //2.UtworzTablice
            //3.WypelnijTablice
            //4.WyswietlTablice
            //5.ObliczSume
            //Funkcja WczytajLiczbe wczytuje liczbę z klawiatury i zwraca ją jako wartość typu int.Funkcja sprawdza, czy podana wartość
            //jest poprawną liczbą dodatnią i w razie błędu wyświetla komunikat i prosi o ponowne wprowadzenie danych.Funkcja umożliwia
            //również zakończenie programu przez wpisanie litery q.
            //Funkcja UtworzTablice tworzy tablicę dwuwymiarową o podanych wymiarach i zwraca ją jako wartość typu int[,]. Funkcja
            //wczytuje liczbę wierszy i kolumn tablicy za pomocą funkcji WczytajLiczbe i wyświetla informację o utworzeniu tablicy.
            //Funkcja WypelnijTablice wypełnia tablicę liczbami losowymi z podanego zakresu i zwraca ją jako wartość typu int[,].
            //Funkcja wczytuje dolną i górną granicę zakresu liczb losowych za pomocą funkcji WczytajLiczbe i sprawdza, czy użytkownik
            //ma już utworzoną tablicę. Jeśli nie, funkcja prosi go o utworzenie tablicy za pomocą funkcji UtworzTablice.Funkcja
            //wyświetla informację o wypełnieniu tablicy.
            //Funkcja WyswietlTablice wyświetla zawartość tablicy na ekranie i nie zwraca niczego(void).Funkcja sprawdza, czy
            //użytkownik ma już utworzoną i wypełnioną tablicę. Jeśli nie, funkcja prosi go o utworzenie i wypełnienie tablicy za
            //pomocą funkcji UtworzTablice i WypelnijTablice.
            //Funkcja ObliczSume oblicza sumę elementów na głównej przekątnej tablicy i zwraca ją jako wartość typu int.Funkcja
            //sprawdza, czy użytkownik ma już utworzoną i wypełnioną tablicę. Jeśli nie, funkcja prosi go o utworzenie i wypełnienie
            //tablicy za pomocą funkcji UtworzTablice i WypelnijTablice.Funkcja wyświetla wartość sumy na ekranie.
            Console.WriteLine("Podaj liczbe: ");
            int n = int.Parse(Console.ReadLine());
            int[,] T = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = r.Next(1, 100);
                    Console.Write(T[i, j] + " ");
                }
                Console.WriteLine();
            }
            bool pupa = false;
            string x;
            int[,] A = new int[0, 0];
            while (pupa == false)
            {
                Console.Write("Wybierz funkcję statyczną:\r\n1.WczytajLiczbe\r\n2.UtworzTablice\r\n3.WypelnijTablice\r\n4.WyswietlTablice\r\n5.ObliczSume\r\nLub jesli chcesz wyjsc podaj q\n");
                x = Console.ReadLine();
                if (x == "1")
                {
                    Console.WriteLine(WczytajLiczbe());
                }
                else if (x == "2")
                {
                    A = UtwurzTablice();
                }
                else if (x == "3")
                {
                    WypelnijTablice(A);
                }
                else if (x == "4")
                {
                    WyswietlTablice(A);
                }
                else if (x == "5")
                {
                    Console.WriteLine(ObliczSume(A));
                }
                else if(x == "q")
                {
                    pupa = true;
                }
                else Console.WriteLine("Podano niepoprawne dane.");
            }
        }
        static int WczytajLiczbe()
        {
            int x = 0;
            string y;
            bool f=false;
            while (f == false)
            {
                Console.WriteLine("Podaj liczbe: ");
                while(!int.TryParse(Console.ReadLine(), out x))
                {
                    y=x.ToString();
                    Console.WriteLine("Podana wartosc jest niepoprawna.");
                    if (y == "q") break;
                }
                if (x < 0) Console.WriteLine("Wprowadzono niepoprawna wartosc.");
                else f = true;
            }
            return x;
        }
        static int[,] UtwurzTablice()
        {
            int a = WczytajLiczbe();
            int b = WczytajLiczbe();
            int[,] T = new int[a, b];
            Console.WriteLine("Utworzono tablice.");
            return T;
        }
        static int[,] WypelnijTablice(int[,] T)
        {   
            Console.WriteLine("Podaj dolna granice: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj gorna granice: ");
            int b=int.Parse(Console.ReadLine());
            Random r = new Random();
            for(int i = 0; i < T.GetLength(0); i++)
            {
                for(int j=0; j < T.GetLength(1); j++)
                {
                    T[i,j]=r.Next(a,b);
                }
            }
            Console.WriteLine("Wypelniono tablice.");
            return T;
        }
        static void WyswietlTablice(int[,] T)
        {
            for(int i=0; i < T.GetLength(0); i++)
            {
                for(int j=0;j< T.GetLength(1); j++)
                {
                    Console.Write(T[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int ObliczSume(int[,] T)
        {
            int suma = 0;
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        suma = suma + T[i, j];
                    }
                }
            }
            Console.WriteLine("Suma elementow na diagonali wynosi:");
            return suma;
        }
    }
}
