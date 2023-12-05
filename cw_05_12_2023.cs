using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw_05_12_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tworzenie listy liczb całkowitych
            //List<int> ints = new List<int>();//nazwa klasy+nazwa zmiennej+nazwa+new=nazwa klasy+nazwa zmiennej

            //Tworzenie listy liczb całkowitych z początkowymi elementami, używając inicjalizatora kolekcja
            //List<int> ints1 = new List<int>() { 1, 2, 3, 10, -2 };

            //Dodawanie elementow do list za pomocą Add()
            //ints1.Add(69);

            //Usuwanie elementów z listy za pomocą Remove()
            //ints1.Remove(1);

            //Wyświetlanie ługości listy za pomocą właściwości Count
            //Console.WriteLine("Długość listy: " + ints1.Count);

            //Wyświetlenie elementó listy
            //foreach (int i in ints1)
            //{
            //    Console.Write(i + " ");
            //}

            //•	Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
            //•	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne
            //przez 3 lub 5.
            //•	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
            //List<int> list = new List<int>();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(r.Next(1, 100));
            //    Console.Write(list[i] + " ");
            //}
            //Console.WriteLine();
            //metoda(list);
            //}
            /*
                •	Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi wartościami z zakresu 
                    od 1 do 100.
                •	Napisz program, który wyświetla menu z pięcioma opcjami, co chcesz zrobić z listą:
                •	Wyświetlić listę liczb podzielnych przez 3 lub 5
                •	Wyświetlić listę liczb nieparzystych
                •	Wyświetlić listę liczb posortowanych rosnąco
                •	Wyświetlić listę liczb posortowanych malejąco
                •	Wyjść z programu
                •	Napisz metodę dla każdej opcji, która przyjmuje jako parametr listę liczb i zwraca listę liczb 
                    spełniających warunek danej opcji.
                •	Napisz kod, który obsługuje wybór użytkownika i wywołuje odpowiednią metodę, a następnie wyświetla
                    wynikową listę na konsoli.
                •	Napisz kod, który powtarza wyświetlanie menu i obsługę wyboru, dopóki użytkownik nie wybierze 
                    opcji wyjścia z programu.
            */
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(r.Next(1, 100));
                Console.Write(list[i] + " ");
            }
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1-Wyświetlić listę liczb podzielnych przez 3 lub 5\n");
                Console.WriteLine("2-Wyświetlić listę liczb nieparzystych");
                Console.WriteLine("3-Wyświetlić listę liczb posortowanych rosnąco");
                Console.WriteLine("4-Wyświetlić listę liczb posortowanych malejąco");
                Console.WriteLine("5-Wyjść z programu");
                Console.WriteLine("Podaj co chcesz: ");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 5);
            switch(choice)
            {
                case 1:
                    metoda(list);
                case 2:
                    parzystaczynie(list);
                case 3:

            }
        }
        public static void metoda(List<int> list)
        {
            foreach (int i in list)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void parzystaczynie(List<int> list)
        {
            foreach(int i in list)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
